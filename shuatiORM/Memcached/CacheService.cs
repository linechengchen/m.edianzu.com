using Memcached.ClientLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace AgileFrame.Orm.PersistenceLayer.Model
{
    public class CacheService
    {
        public List<string> localserverlist = new List<string>(){ "127.0.0.1:11211" };
        public List<string> serverlist = new List<string>() { "10.66.188.151:9101" };

        public static bool Ping()
        {
            string ip = "10.66.188.151:9101".Split(':')[0];
            int port = Convert.ToInt32("10.66.188.151:9101".Split(':')[1]);
            TcpClient tcpclient = new TcpClient(ip, port);  // 连接服务器
            NetworkStream stream = tcpclient.GetStream();   // 获取网络数据流对象
            StreamWriter sw = new StreamWriter(stream);
            StreamReader sr = new StreamReader(stream);
            while (true)
            {
                //Read Echo
                //Set ReadEcho Timeout
                stream.ReadTimeout = 10;
                try
                {
                    while (true)
                    {
                        char c = (char)sr.Read();
                        if (c < 256)
                        {
                            if (c == 27)
                            {
                                while (sr.Read() != 109) { }
                            }
                            else
                            {
                                Console.Write(c);
                            }
                        }
                    }
                }
                catch
                {

                }
                //Send CMD
                sw.Write("{0}\r\n", Console.ReadLine());
                sw.Flush();
            }
            return false;
        }
        MemcachedClient mc = null;
        public MemcachedClient Factory()
        {
            if (mc == null)
            {
                try
                {
                    //初始化池           
                    SockIOPool sock = SockIOPool.GetInstance();
                    sock.SetServers(serverlist.ToArray());//添加服务器列表
                    sock.InitConnections = 3;//设置连接池初始数目           
                    sock.MinConnections = 3;//设置最小连接数目           
                    sock.MaxConnections = 5;//设置最大连接数目           
                    sock.SocketConnectTimeout = 1000;//设置连接的套接字超时。           
                    sock.SocketTimeout = 3000;//设置套接字超时读取           
                    sock.MaintenanceSleep = 30;//设置维护线程运行的睡眠时间。如果设置为0，那么维护线程将不会启动;  

                    //获取或设置池的故障标志。
                    //如果这个标志被设置为true则socket连接失败，
                    //将试图从另一台服务器返回一个套接字如果存在的话。
                    //如果设置为false，则得到一个套接字如果存在的话。否则返回NULL，如果它无法连接到请求的服务器。
                    sock.Failover = true;            //如果为false，对所有创建的套接字关闭Nagle的算法。
                    sock.Nagle = false;

                    sock.Initialize();

                    mc = new MemcachedClient();
                    mc.EnableCompression = true; //是否启用压缩数据
                    mc.Set("key1", "value1");
                }
                catch (Exception ex1)
                {
                    AgileFrame.Core.Cs.Error(ex1.ToString());
                }
            }
            return mc;
        }

        //更多的是存储一个自定义的类的实例对象。这就需要使用到序列化，下面我们来新加一个类MyObject，让其作为可序列化的对象来存储进Memcached中
        public void MemcachedTest(string[] args)
        {           
            //初始化池           
            SockIOPool sock = SockIOPool.GetInstance();
            sock.SetServers(serverlist.ToArray());//添加服务器列表
            sock.InitConnections = 3;//设置连接池初始数目           
            sock.MinConnections = 3;//设置最小连接数目           
            sock.MaxConnections = 5;//设置最大连接数目           
            sock.SocketConnectTimeout = 1000;//设置连接的套接字超时。           
            sock.SocketTimeout = 3000;//设置套接字超时读取           
            sock.MaintenanceSleep = 30;//设置维护线程运行的睡眠时间。如果设置为0，那么维护线程将不会启动;  

            //获取或设置池的故障标志。           
            //如果这个标志被设置为true则socket连接失败，           
            //将试图从另一台服务器返回一个套接字如果存在的话。           
            //如果设置为false，则得到一个套接字如果存在的话。否则返回NULL，如果它无法连接到请求的服务器。           
            sock.Failover = true;            //如果为false，对所有创建的套接字关闭Nagle的算法。           
            sock.Nagle = false;  

            sock.Initialize();

            MemcachedClient mc = new MemcachedClient();
            mc.EnableCompression = true; //是否启用压缩数据

            //mc.Set(key,val);//设置 键值       
            //mc.KeyExists(key) //键 是否存
            //mc.Get(key)   //获取 一个键值
            //mc.Delete(key);// 删除 键值

            Console.WriteLine("----------------------------Set-----------");
            mc.Set("key1", "value1");
            Console.WriteLine(mc.Get("key1"));
            Console.WriteLine("---------------------------replay---------");
            mc.Replace("key1", "Replay new Key1");
            Console.WriteLine(mc.Get("key1"));
            Console.WriteLine("---------------------------键值是否存在----");
            if (mc.KeyExists("key2"))
            {
                Console.WriteLine("key2存在");
            }
            else
            {
                Console.WriteLine("key2不存在，设置新值");
                mc.Set("key2", "New key2");
            }
            Console.WriteLine("-------------------------删除数据--------");
            mc.Delete("key2");
            Console.WriteLine("删除之后的数据: " + mc.Get("key2"));

            Console.WriteLine("-------------------------数据过期--------");
            mc.Add("key3", "新数据三内容", DateTime.Now.AddMilliseconds(5000));
            Console.WriteLine(mc.Get("key5"));
            System.Threading.Thread.Sleep(6000);
            Console.WriteLine("过期: " + mc.Get("key5"));

            Console.ReadLine();
        }
    }
}

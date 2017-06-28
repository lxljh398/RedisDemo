using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RedisStudy
{
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    class Program
    {
        static RedisHelper redisHelper = new RedisHelper(true);
        
        static void Main(string[] args)
        {
            User u = new User() { Name = "eric1", Id = 1 };
            redisHelper.Set<User>("user", u);//设置缓存
            u=redisHelper.Get<User>("user");
            Console.WriteLine(u.Name);
            
            List<User> list = new List<User>()
            {
                new User(){Name="eric1",Id=1},
                 new User(){Name="eric2",Id=2}
            };
           
            redisHelper.Remove("list1");//删除缓存
            redisHelper.AddList<User>("list1", list);//添加缓存链表
            redisHelper.AddEntityToList<User>("list1", new User() { Name = "eric3",Id=3 });
            list = redisHelper.GetList<User>("list1").ToList();
            Console.WriteLine(list.Count);

            redisHelper.RemoveEntityFromList<User>("list1", list[0]);
            redisHelper.RemoveEntityFromList<User>("list1", it => it.Id == 2);
            list = redisHelper.GetList<User>("list1").ToList();
            Console.WriteLine(list.Count);

            redisHelper.Dispose();
            Console.ReadLine();
             
        }

     
    }
}

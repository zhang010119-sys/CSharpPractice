// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine(E_FirstLesson.zhang);
// enum E_FirstLesson
//     {
//         zhang,
//         han,
//         wen
//     
//     }
//枚举：enum E_XXXXX


using System;
using System.ComponentModel;
using System.Reflection;
using System.Resources;

namespace LessonCS
{
    enum E_Job
    {
        None,
        [Description("战士")]
        Warrior,
        [Description("法师")]
        Mage,
        [Description("射手")]
        Archer,
        [Description("奶妈")]
        Priest
    }
    internal class Program
    {


        public static void ShowSkills(E_Job job)
        {
            string temp = GetDesc(job);
           // Console.WriteLine("当前职业是：");
           Console.WriteLine("你的职业是："+temp);
            switch (job)
            {
                case E_Job.Warrior:
                    
                    Console.WriteLine("技能是："+"砍"); 

                    break;
                case E_Job.Mage:
                    Console.WriteLine("技能是："+"火球"); 
    
                    break;
                case E_Job.Archer:
                    Console.WriteLine("技能是："+"射"); 

                    break;
                case E_Job.Priest:
                    Console.WriteLine("技能是："+"加血"); 

                    break;
                default:
                    Console.WriteLine("错误");

                    break;
            }
        }
        public static string GetDesc(E_Job job)
        {
            FieldInfo Info = job.GetType().GetField(job.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])Info.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return job.ToString();
            }
            
            
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入职业：");
                String Player = Console.ReadLine();
                
                if (Player == "0")
                {
                    break;
                }
                else
                {
                    Enum.TryParse<E_Job>(Player, true, out E_Job job);
                    ShowSkills(job);
                }
                
            }
        }


        //     E_Player playerType = E_Player.MainPlayer;
        //     Console.WriteLine("玩家类型："+playerType);
        //     //E_Monster MonsterType = E_Monster.Boss;
        //     String MonsterType = Console.ReadLine();
        //     String Boss = E_Monster.Boss.ToString();
        //     String Normal = E_Monster.Normal.ToString();
        //     int S1;
        //     if (MonsterType == Boss)
        //     {
        //         Console.WriteLine(Boss);
        //         S1 = 1;
        //     }
        //     else if (MonsterType == Normal)
        //     {
        //         Console.WriteLine(Normal);
        //         S1 = 2;
        //     }
        //     else
        //     {
        //         S1 = 3;
        //     }
        //     switch (S1)
        //     {   
        //         case 1:
        //             Console.WriteLine("Boss类型："+MonsterType);
        //             break;
        //         case 2:
        //             Console.WriteLine("Boss类型："+MonsterType);
        //             break;
        //         default:
        //             Console.WriteLine("XXXxxx");
        //             break;
        //     }
        // }
        //
    }
}
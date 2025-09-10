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

namespace LessonCS
{
    enum E_FirstLesson
    {
        zhang,
        han,
        wen
    }    enum E_Monster
    {
        Boss,
        Normal
    }    enum E_Player
    {
        MainPlayer,
        NPC
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            E_Player playerType = E_Player.MainPlayer;
            Console.WriteLine("玩家类型："+playerType);
            //E_Monster MonsterType = E_Monster.Boss;
            String MonsterType = Console.ReadLine();
            
            switch (MonsterType)
            {   
                case E_Monster.Boss:
                    Console.WriteLine("Boss类型："+MonsterType);
                    break;
                case E_Monster.Normal:
                    Console.WriteLine("Boss类型："+MonsterType);
                    break;
                default:
                    Console.WriteLine("XXXxxx");
                    break;
            }
        }
        
    }
}
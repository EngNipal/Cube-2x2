using System;
/*using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace Cube_2x2
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----Создание куба и установка начальной позиции-----
            Cube2x2x2 TrainCube = new Cube2x2x2();
            TrainCube.SetSolved();

            //TrainCube.Print();

            // -----Считывание и сплит строки, на основе которой выполняется скрамблинг-----
            string Input;
            Console.WriteLine("Введите скрамбл");
            Input = Console.ReadLine();
            string[] Scramble = Input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // -----Скрамблинг-----
            foreach (string move in Scramble)
            {
                switch (move)
                {
                    case "R":
                        TrainCube.R();
                        break;
                    case "R'":
                        TrainCube.Rp();
                        break;
                    case "R2":
                        TrainCube.R2();
                        break;
                    case "U":
                        TrainCube.U();
                        break;
                    case "U'":
                        TrainCube.Up();
                        break;
                    case "U2":
                        TrainCube.U2();
                        break;
                    case "F":
                        TrainCube.F();
                        break;
                    case "F'":
                        TrainCube.Fp();
                        break;
                    case "F2":
                        TrainCube.F2();
                        break;
                    default:
                        Console.WriteLine("Ваш скрамбл содержит недопустимые ходы, корректная работа не гарантируется");
                        break;
                }
            }            
            // -----Вывод-----
            TrainCube.Print();

            // -----Генерация скрамбла рандомайзером-----
            /*int ScrambleLength;
            Random Length = new Random();
            ScrambleLength = Length.Next(1, 10);
            // массив собирает числовые коды ходов
            int[] Moves = new int[10];
            Random Generator = new Random();
            
            for (byte i = 0; i < ScrambleLength; i++)
            {
                Moves[i] = Generator.Next(1, 9);
            }*/
        }
    }
}

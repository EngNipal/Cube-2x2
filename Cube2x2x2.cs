using System;
using System.Collections;
/*using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace Cube_2x2
{
    public class Cube2x2x2
    {
        // Константы, определяющие количество строк и столбцов массива состояния куба
        private const byte Rows = 6, Columns = 4;
        // Массив, содержащий состояние куба
        private byte[,] _state = new byte[Rows, Columns];
        public byte[,] State
        {
            get { return _state; }
            set
            {
                for (byte i = 0; i < Rows; i++)
                {
                    for (byte j = 0; j < Columns; j++)
                    {
                        byte element = value[i, j];
                        _state[i, j] = element;
                    }

                }
            }
        }
        // Далее методы, реализующие ходы (R, R' - Rp, R2, U, U', U2, F, F', F2).
        public void R()
        {
            byte Changer;
            Changer = _state[0, 1];
            _state[0, 1] = _state[2, 1];
            _state[2, 1] = _state[5, 1];
            _state[5, 1] = _state[4, 2];
            _state[4, 2] = Changer;
            Changer = _state[0, 3];
            _state[0, 3] = _state[2, 3];
            _state[2, 3] = _state[5, 3];
            _state[5, 3] = _state[4, 0];
            _state[4, 0] = Changer;
            Changer = _state[3, 0];
            _state[3, 0] = _state[3, 2];
            _state[3, 2] = _state[3, 3];
            _state[3, 3] = _state[3, 1];
            _state[3, 1] = Changer;
        }
        public void Rp()
        {
            byte Changer;
            Changer = _state[0, 1];
            _state[0, 1] = _state[4, 2];
            _state[4, 2] = _state[5, 1];
            _state[5, 1] = _state[2, 1];
            _state[2, 1] = Changer;
            Changer = _state[0, 3];
            _state[0, 3] = _state[4, 0];
            _state[4, 0] = _state[5, 3];
            _state[5, 3] = _state[2, 3];
            _state[2, 3] = Changer;
            Changer = _state[3, 0];
            _state[3, 0] = _state[3, 1];
            _state[3, 1] = _state[3, 3];
            _state[3, 3] = _state[3, 2];
            _state[3, 2] = Changer;
        }
        public void R2()
        {
            byte Changer;
            Changer = _state[0, 1];
            _state[0, 1] = _state[5, 1];
            _state[5, 1] = Changer;
            Changer = _state[4, 2];
            _state[4, 2] = _state[2, 1];
            _state[2, 1] = Changer;
            Changer = _state[0, 3];
            _state[0, 3] = _state[5, 3];
            _state[5, 3] = Changer;
            Changer = _state[4, 0];
            _state[4, 0] = _state[2, 3];
            _state[2, 3] = Changer;
            Changer = _state[3, 0];
            _state[3, 0] = _state[3, 3];
            _state[3, 3] = Changer;
            Changer = _state[3, 1];
            _state[3, 1] = _state[3, 2];
            _state[3, 2] = Changer;
        }
        public void U()
        {
            byte Changer;
            Changer = _state[1, 0];
            _state[1, 0] = _state[2, 0];
            _state[2, 0] = _state[3, 0];
            _state[3, 0] = _state[4, 0];
            _state[4, 0] = Changer;
            Changer = _state[1, 1];
            _state[1, 1] = _state[2, 1];
            _state[2, 1] = _state[3, 1];
            _state[3, 1] = _state[4, 1];
            _state[4, 1] = Changer;
            Changer = _state[0, 0];
            _state[0, 0] = _state[0, 2];
            _state[0, 2] = _state[0, 3];
            _state[0, 3] = _state[0, 1];
            _state[0, 1] = Changer;
        }
        public void Up()
        {
            byte Changer;
            Changer = _state[1, 0];
            _state[1, 0] = _state[4, 0];
            _state[4, 0] = _state[3, 0];
            _state[3, 0] = _state[2, 0];
            _state[2, 0] = Changer;
            Changer = _state[1, 1];
            _state[1, 1] = _state[4, 1];
            _state[4, 1] = _state[3, 1];
            _state[3, 1] = _state[2, 1];
            _state[2, 1] = Changer;
            Changer = _state[0, 0];
            _state[0, 0] = _state[0, 1];
            _state[0, 1] = _state[0, 3];
            _state[0, 3] = _state[0, 2];
            _state[0, 2] = Changer;
        }
        public void U2()
        {
            byte Changer;
            Changer = _state[1, 0];
            _state[1, 0] = _state[3, 0];
            _state[3, 0] = Changer;
            Changer = _state[2, 0];
            _state[2, 0] = _state[4, 0];
            _state[4, 0] = Changer;
            Changer = _state[1, 1];
            _state[1, 1] = _state[3, 1];
            _state[3, 1] = Changer;
            Changer = _state[2, 1];
            _state[2, 1] = _state[4, 1];
            _state[4, 1] = Changer;
            Changer = _state[0, 0];
            _state[0, 0] = _state[0, 3];
            _state[0, 3] = Changer;
            Changer = _state[0, 1];
            _state[0, 1] = _state[0, 2];
            _state[0, 2] = Changer;
        }
        public void F()
        {
            byte Changer;
            Changer = _state[0, 2];
            _state[0, 2] = _state[1, 3];
            _state[1, 3] = _state[5, 1];
            _state[5, 1] = _state[3, 0];
            _state[3, 0] = Changer;
            Changer = _state[0, 3];
            _state[0, 3] = _state[1, 1];
            _state[1, 1] = _state[5, 0];
            _state[5, 0] = _state[3, 2];
            _state[3, 2] = Changer;
            Changer = _state[2, 0];
            _state[2, 0] = _state[2, 2];
            _state[2, 2] = _state[2, 3];
            _state[2, 3] = _state[2, 1];
            _state[2, 1] = Changer;
        }
        public void Fp()
        {
            byte Changer;
            Changer = _state[0, 2];
            _state[0, 2] = _state[3, 0];
            _state[3, 0] = _state[5, 1];
            _state[5, 1] = _state[1, 3];
            _state[1, 3] = Changer;
            Changer = _state[0, 3];
            _state[0, 3] = _state[3, 2];
            _state[3, 2] = _state[5, 0];
            _state[5, 0] = _state[1, 1];
            _state[1, 1] = Changer;
            Changer = _state[2, 0];
            _state[2, 0] = _state[2, 1];
            _state[2, 1] = _state[2, 3];
            _state[2, 3] = _state[2, 2];
            _state[2, 2] = Changer;
        }
        public void F2()
        {
            byte Changer;
            Changer = _state[0, 2];
            _state[0, 2] = _state[5, 1];
            _state[5, 1] = Changer;
            Changer = _state[1, 3];
            _state[1, 3] = _state[3, 0];
            _state[3, 0] = Changer;
            Changer = _state[0, 3];
            _state[0, 3] = _state[5, 0];
            _state[5, 0] = Changer;
            Changer = _state[1, 1];
            _state[1, 1] = _state[3, 2];
            _state[3, 2] = Changer;
            Changer = _state[2, 0];
            _state[2, 0] = _state[2, 3];
            _state[2, 3] = Changer;
            Changer = _state[2, 1];
            _state[2, 1] = _state[2, 2];
            _state[2, 2] = Changer;
        }
        //Метод задаёт исходное состояние куба
        internal void SetSolved()
        {
            for (byte i = 0; i < Rows; i++)
            {
                for (byte j = 0; j < Columns; j++)
                {
                    _state[i, j] = (byte)(i + 1);
                }
            }
        }
        //Метод проверяет, является ли текущее состояние куба исходным
        internal bool IsSolved()
        {
            bool flag = true;
            byte i = 0, j;
            while (flag && (i < Rows))
            {
                j = 0;
                while (flag && (j < Columns))
                {
                    if (_state[i, j] != (i + 1))
                    {
                        flag = false;
                    }
                    j++;
                }
                i++;
            }
            return flag;
        }        
        //Метод выводит текущее состояние куба в консоль
        internal void Print()
        {
            for (byte i = 0; i < Rows; i++)
            {
                for (byte j = 0; j < Columns; j++)
                {
                    Console.Write(_state[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
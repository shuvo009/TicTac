using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace NUnitTest
{
    [TestFixture]
    public class Class1
    {
        private enum EnTicTac
        {
            Non,
            Tic,
            Tac
        }
        private  EnTicTac[,] _enTicTacs = new EnTicTac[3, 3];
     private bool CheckRow(int start)
        {
            EnTicTac tac = _enTicTacs[start, 0];
            for (int i = 1; i < 3; i++)
            {
                if (tac == _enTicTacs[start, i])
                {
                    tac = _enTicTacs[start, i];
                }
                else
                {
                    return false;
                }

            }
         return true;
        }
        [Test]
        private void CheckRowTest()
        {
            _enTicTacs[0,0]=EnTicTac.Tac;
            _enTicTacs[0, 1] = EnTicTac.Tac;
            _enTicTacs[0, 2] = EnTicTac.Tac;

            var value = CheckRow(0);

            Assert.IsTrue(value);
        }

    }



}

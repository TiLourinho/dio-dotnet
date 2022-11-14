using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class Files
    {
        public (bool IsSuccessful, string[] Rows, int QuantityRows) ReadFile(string path)
        {
            try
            {
                string[] rows = File.ReadAllLines(path);
                (bool, string[], int) result = (true, rows, rows.Length);

                return result;
            }
            catch (Exception)
            {
                (bool, string[], int) result = (false, new string[0], 0);
                return result;
            }
        }
    }
}
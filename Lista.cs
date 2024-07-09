using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public class Lista<T> where T : IComparable<T>
    {
        private List<T> lista = new List<T>();

        public List<T> Get()
        {
            return new List<T>(lista);
        }

        private bool StringaValida(T valore)
        {
            if (valore is string s)
            {
                return !string.IsNullOrEmpty(s) && !string.IsNullOrWhiteSpace(s);
            }
            return true;
        }

        public void InserisciInTesta(T valore)
        {
            if (StringaValida(valore))
            {
                lista.Insert(0, valore);
            }
            else
            {
                throw new Exception("Valore non valido");
            }
        }

        public void InserisciInCoda(T valore)
        {
            if (StringaValida(valore))
            {
                lista.Add(valore);
            }
            else
            {
                throw new Exception("Valore non valido");
            }
        }

        public void InserisciInPosizione(T valore, int posizione)
        {
            if (StringaValida(valore))
            {
                if (posizione >= 0 && posizione <= lista.Count)
                {
                    lista.Insert(posizione, valore);
                }
                else
                {
                    throw new Exception("Posizione non valida");
                }
            }
            else
            {
                throw new Exception("Valore non valido");
            }
        }

        public void InserisciInOrdine(T valore)
        {
            if (StringaValida(valore))
            {
                int i = 0;
                bool flag = false;
                while (i < lista.Count && flag == false)
                {
                    if (valore.CompareTo(lista[i]) <= 0)
                    {
                        flag = true;
                    }
                    i++;
                }
                if (flag)
                {
                    lista.Insert(i - 1, valore);
                }
                else
                {
                    lista.Add(valore);
                }
            }
            else
            {
                throw new Exception("Valore non valido");
            }
        }

        public void CancellaPerValore(T valore)
        {
            if (StringaValida(valore))
            {
                lista.RemoveAll(x => x.Equals(valore));
            }
            else
            {
                throw new Exception("Valore non presente");
            }
        }

        public void CancellaPerPosizione(int posizione)
        {
            if (posizione >= 0 && posizione < lista.Count)
            {
                lista.RemoveAt(posizione);
            }
            else
            {
                throw new Exception("Posizione non valida");
            }
        }

        public void Clear()
        {
            lista.Clear();
        }
    }
}

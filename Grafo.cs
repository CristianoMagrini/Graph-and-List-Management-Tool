using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public class Grafo<T>
    {
        List<Nodo<T>> grafo = new List<Nodo<T>>();

        public List<Nodo<T>> Get()
        {
            return new List<Nodo<T>>(grafo);
        }

        public int Count()
        {
            return grafo.Count;
        }

        public Nodo<T> Trova(T valore)
        {
            foreach (var v in grafo)
            {
                if (v.valore.Equals(valore))
                {
                    return v;
                }
            }
            return null;
        }

        public bool AggiungiNodo(T valore)
        {
            if (Trova(valore) == null)
            {
                grafo.Add(new Nodo<T>(valore));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AggiungiArco(T v1, T v2)
        {
            Nodo<T> n1 = Trova(v1);
            Nodo<T> n2 = Trova(v2);
            if (n1 != null && n2 != null && !n1.listaVicini.Contains(n2))
            {
                n1.AggiungiVicino(n2);
                return true;
            }
            return false;
        }

        public bool EliminaNodo(T valore)
        {
            Nodo<T> n = Trova(valore);
            if (n != null)
            {
                foreach (var nodo in grafo)
                {
                    nodo.EliminaVicino(n);
                }
                grafo.Remove(n);
                return true;
            }
            return false;
        }

        public bool EliminaArco(T v1, T v2)
        {
            Nodo<T> n1 = Trova(v1);
            Nodo<T> n2 = Trova(v2);
            if (n1 != null && n2 != null && n1.listaVicini.Contains(n2))
            {
                n1.EliminaVicino(n2);
                return true;
            }
            return false;
        }

        public List<Nodo<T>> BFS(Nodo<T> radice)
        {
            List<Nodo<T>> visitati = new List<Nodo<T>>();
            Queue<Nodo<T>> frontiere = new Queue<Nodo<T>>();
            Nodo<T> corrente;
            frontiere.Enqueue(radice);
            while (frontiere.Count > 0)
            {
                corrente = frontiere.Dequeue();
                foreach (Nodo<T> vicino in corrente.listaVicini)
                {
                    if (!frontiere.Contains(vicino) && !visitati.Contains(vicino))
                    {
                        frontiere.Enqueue(vicino);
                    }
                }
                visitati.Add(corrente);
            }
            return visitati;
        }

        public List<Nodo<T>> DFS(Nodo<T> radice)
        {
            List<Nodo<T>> visitati = new List<Nodo<T>>();
            Stack<Nodo<T>> frontiere = new Stack<Nodo<T>>();
            Nodo<T> corrente;
            frontiere.Push(radice);
            while (frontiere.Count > 0)
            {
                corrente = frontiere.Pop();
                foreach (Nodo<T> vicino in corrente.listaVicini)
                {
                    if (!frontiere.Contains(vicino) && !visitati.Contains(vicino))
                    {
                        frontiere.Push(vicino);
                    }
                }
                visitati.Add(corrente);
            }
            return visitati;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Count(); i++)
            {
                sb.Append(grafo[i].ToString());
                if (i < Count() - 1)
                {
                    sb.Append("\n");
                }

            }
            return sb.ToString();
        }
    }

    public class Nodo<T>
    {
        public T valore;
        public List<Nodo<T>> listaVicini;

        public Nodo(T valore)
        {
            this.valore = valore;
            listaVicini = new List<Nodo<T>>();
        }

        public bool AggiungiVicino(Nodo<T> vicino)
        {
            if (!listaVicini.Contains(vicino))
            {
                listaVicini.Add(vicino);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminaVicino(Nodo<T> vicino)
        {
            if (listaVicini.Contains(vicino))
            {
                listaVicini.Remove(vicino);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nodo: " + valore);
            int conta = 0;
            foreach (var v in listaVicini) {
                if(v != null)
                {
                    if(conta == 0)
                    {
                        sb.Append(" -> " + v.valore);
                        conta++;
                    }
                    else
                    {
                        sb.Append(", " + v.valore);
                    }
                    
                }
            }
            return sb.ToString();
        }
    } 
}

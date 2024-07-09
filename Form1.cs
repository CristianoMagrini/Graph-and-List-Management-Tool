using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public partial class FormLista_Grafo : Form
    {
        bool tipo;
        Lista<string> listaS = new Lista<string>();
        Lista<int> listaI = new Lista<int>();
        Grafo<string> grafoS = new Grafo<string>();
        Grafo<int> grafoI = new Grafo<int>();
        public FormLista_Grafo()
        {
            InitializeComponent();
        }

        private void FormLista_Grafo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Scegli se lavorare con gli interi o con le stringhe", "Scelta tipo variabili");
            tabLista_Grafo.Visible = false;
            txbPosizioneI.Visible = false;
            lblPosizioneI.Visible = false;
            txbValoreC.Visible = false;
            lblValoreC.Visible = false;
            txbPosizioneC.Visible = false;
            lblPosizioneC.Visible = false;
            rbtnInt.Checked = false;
            rbtnString.Checked = false;
            btnSommaG.Visible = false;
            lblSommaG.Visible = false;
            txbSommaG.Visible = false;
            btnTrovaG.Visible = false;
            lblTrovaG.Visible = false;
            txbTrovaG.Visible = false;
        }

        private void rbtnInt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnInt.Checked)
            {
                DialogResult result = MessageBox.Show("Sei sicuro di lavorare con gli interi?", "Interi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    tipo = false;
                    rbtnInt.Enabled = false;
                    rbtnString.Enabled = false;
                    tabLista_Grafo.Visible = true;
                    btnSommaG.Visible = true;
                    lblSommaG.Visible = true;
                    txbSommaG.Visible = true;
                }
                else
                {
                    rbtnInt.Checked = false;
                }
            }
        }

        private void rbtnString_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnString.Checked)
            {
                DialogResult result = MessageBox.Show("Sei sicuro di lavorare con le stringhe?", "Stringhe", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    tipo = true;
                    rbtnInt.Enabled = false;
                    rbtnString.Enabled = false;
                    tabLista_Grafo.Visible = true;
                    btnTrovaG.Visible = true;
                    lblTrovaG.Visible = true;
                    txbTrovaG.Visible = true;
                }
                else
                {
                    rbtnString.Checked = false;
                }
            }
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Gestione Lista

        private void AggiornaLista()
        {
            lbLista.Items.Clear();
            if (tipo)
            {
                foreach (string s in listaS.Get())
                {
                    lbLista.Items.Add(s);
                }
            }
            else
            {
                foreach (int n in listaI.Get())
                {
                    lbLista.Items.Add(n);
                }
            }

        }

        private void rbtnPosizioneI_CheckedChanged(object sender, EventArgs e)
        {
            txbPosizioneI.Visible = rbtnPosizioneI.Checked;
            lblPosizioneI.Visible = rbtnPosizioneI.Checked;
        }

        private void rbtnValoreC_CheckedChanged(object sender, EventArgs e)
        {
            txbValoreC.Visible = rbtnValoreC.Checked;
            lblValoreC.Visible = rbtnValoreC.Checked;
        }

        private void rbtnPosizioneC_CheckedChanged(object sender, EventArgs e)
        {
            txbPosizioneC.Visible = rbtnPosizioneC.Checked;
            lblPosizioneC.Visible = rbtnPosizioneC.Checked;
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbValoreI.Text) && !string.IsNullOrWhiteSpace(txbValoreI.Text))
            {
                int n;
                if (rbtnTestaI.Checked)
                {
                    if (tipo)
                    {
                        listaS.InserisciInTesta(txbValoreI.Text);
                    }
                    else
                    {
                        if (int.TryParse(txbValoreI.Text, out n))
                        {
                            listaI.InserisciInTesta(n);
                        }
                        else
                        {
                            MessageBox.Show("Intero non valido");
                        }
                    }

                }
                else if (rbtnCodaI.Checked)
                {
                    if (tipo)
                    {
                        listaS.InserisciInCoda(txbValoreI.Text);
                    }
                    else
                    {
                        if (int.TryParse(txbValoreI.Text, out n))
                        {
                            listaI.InserisciInCoda(n);
                        }
                        else
                        {
                            MessageBox.Show("Intero non valido");
                        }
                    }
                }
                else if (rbtnPosizioneI.Checked)
                {
                    int posizioneI;
                    bool p = false;
                    if (tipo)
                    {
                        if (int.TryParse(txbPosizioneI.Text, out posizioneI) && posizioneI >= 0 && posizioneI <= listaS.Get().Count)
                        {
                            listaS.InserisciInPosizione(txbValoreI.Text, posizioneI);
                        }
                        else
                        {
                            p = true;
                        }
                    }
                    else
                    {
                        if (int.TryParse(txbValoreI.Text, out n))
                        {
                            if (int.TryParse(txbPosizioneI.Text, out posizioneI) && posizioneI >= 0 && posizioneI <= listaI.Get().Count)
                            {
                                listaI.InserisciInPosizione(n, posizioneI);
                            }
                            else
                            {
                                p = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Intero non valido");
                        }
                    }
                    if (p)
                    {
                        MessageBox.Show("Posizione non valida");
                    }
                }
                else if (rbtnOrdineI.Checked)
                {
                    if (tipo)
                    {
                        listaS.InserisciInOrdine(txbValoreI.Text);
                    }
                    else
                    {
                        if (int.TryParse(txbValoreI.Text, out n))
                        {
                            listaI.InserisciInOrdine(n);
                        }
                        else
                        {
                            MessageBox.Show("Intero non valido");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Modalità di inserimento non selezionata");
                }
                txbValoreI.Clear();
                txbPosizioneI.Clear();
                AggiornaLista();
            }
            else
            {
                MessageBox.Show("Valore non valido");
            }
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            if (rbtnValoreC.Checked)
            {
                int n;
                if (!string.IsNullOrEmpty(txbValoreC.Text) && !string.IsNullOrWhiteSpace(txbValoreC.Text))
                {
                    if (tipo)
                    {
                        if (listaS.Get().Contains(txbValoreC.Text))
                        {
                            listaS.CancellaPerValore(txbValoreC.Text);
                        }
                        else
                        {
                            MessageBox.Show("Valore non presente nella lista");
                        }
                    }
                    else
                    {
                        if (int.TryParse(txbValoreC.Text, out n))
                        {
                            if (listaI.Get().Contains(n))
                            {
                                listaI.CancellaPerValore(n);
                            }
                            else
                            {
                                MessageBox.Show("Valore non presente nella lista");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Intero non valido");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Valore non valido");
                }
            }
            else if (rbtnPosizioneC.Checked)
            {
                int posizioneC;
                if (int.TryParse(txbPosizioneC.Text, out posizioneC) && posizioneC >= 0)
                {
                    if (tipo)
                    {
                        if (posizioneC < listaS.Get().Count)
                        {
                            listaS.CancellaPerPosizione(posizioneC);
                        }
                        else
                        {
                            MessageBox.Show("Posizione non presente nella lista");
                        }
                    }
                    else
                    {
                        if (posizioneC < listaI.Get().Count)
                        {
                            listaI.CancellaPerPosizione(posizioneC);
                        }
                        else
                        {
                            MessageBox.Show("Posizione non presente nella lista");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Posizione non valida");
                }
            }
            txbValoreC.Clear();
            txbPosizioneC.Clear();
            AggiornaLista();
        }

        //Gestione Grafo

        private void btnAggiungiN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbNodoA.Text) && !string.IsNullOrWhiteSpace(txbNodoA.Text))
            {
                bool a;
                int n;
                if (tipo)
                {
                    a = grafoS.AggiungiNodo(txbNodoA.Text);
                    rtxbGrafo.Text = grafoS.ToString();
                    if (!a)
                    {
                        MessageBox.Show("Nodo già esistente");
                    }
                }
                else
                {
                    if (int.TryParse(txbNodoA.Text, out n))
                    {
                        a = grafoI.AggiungiNodo(n);
                        rtxbGrafo.Text = grafoI.ToString();
                        if (!a)
                        {
                            MessageBox.Show("Nodo già esistente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Intero non valido");
                    }
                }
                txbNodoA.Clear();
            }
            else
            {
                MessageBox.Show("Valore non valido");
            }
        }

        private void btnAggiungiA_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbArcoA1.Text) && !string.IsNullOrWhiteSpace(txbArcoA1.Text) && !string.IsNullOrEmpty(txbArcoA2.Text) && !string.IsNullOrWhiteSpace(txbArcoA2.Text) && txbArcoA1.Text != txbArcoA2.Text)
            {
                bool a;
                int n1, n2;
                if (tipo)
                {
                    a = grafoS.AggiungiArco(txbArcoA1.Text, txbArcoA2.Text);
                    rtxbGrafo.Text = grafoS.ToString();
                    if (!a)
                    {
                        MessageBox.Show("Uno dei nodi non è presente o l'arco è già stato creato");
                    }
                }
                else
                {
                    if (int.TryParse(txbArcoA1.Text, out n1) && int.TryParse(txbArcoA2.Text, out n2))
                    {
                        a = grafoI.AggiungiArco(n1, n2);
                        rtxbGrafo.Text = grafoI.ToString();
                        if (!a)
                        {
                            MessageBox.Show("Uno dei nodi non è presente o l'arco è già stato creato");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Intero non valido");
                    }
                }
                txbArcoA1.Clear();
                txbArcoA2.Clear();
            }
            else
            {
                MessageBox.Show("Valore non valido");
            }
        }

        private void btnEliminaN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbNodoE.Text) && !string.IsNullOrWhiteSpace(txbNodoE.Text))
            {
                bool a;
                int n;
                if (tipo)
                {
                    a = grafoS.EliminaNodo(txbNodoE.Text);
                    rtxbGrafo.Text = grafoS.ToString();
                    if (!a)
                    {
                        MessageBox.Show("Nodo non presente");
                    }
                }
                else
                {
                    if (int.TryParse(txbNodoE.Text, out n))
                    {
                        a = grafoI.EliminaNodo(n);
                        rtxbGrafo.Text = grafoI.ToString();
                        if (!a)
                        {
                            MessageBox.Show("Nodo non presente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Intero non valido");
                    }
                }
                txbNodoE.Clear();
            }
            else
            {
                MessageBox.Show("Valore non valido");
            }
        }

        private void btnEliminaA_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbArcoE1.Text) && !string.IsNullOrWhiteSpace(txbArcoE1.Text) && !string.IsNullOrEmpty(txbArcoE2.Text) && !string.IsNullOrWhiteSpace(txbArcoE2.Text) && txbArcoE1.Text != txbArcoE2.Text)
            {
                bool a;
                int n1, n2;
                if (tipo)
                {
                    a = grafoS.EliminaArco(txbArcoE1.Text, txbArcoE2.Text);
                    rtxbGrafo.Text = grafoS.ToString();
                    if (!a)
                    {
                        MessageBox.Show("Arco non presente");
                    }
                }
                else
                {
                    if (int.TryParse(txbArcoE1.Text, out n1) && int.TryParse(txbArcoE2.Text, out n2))
                    {
                        a = grafoI.EliminaArco(n1, n2);
                        rtxbGrafo.Text = grafoI.ToString();
                        if (!a)
                        {
                            MessageBox.Show("Arco non presente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Intero non valido");
                    }
                }
                txbArcoE1.Clear();
                txbArcoE2.Clear();
            }
            else
            {
                MessageBox.Show("Valore non valido");
            }
        }

        private void VisualizzaVisitati<T>(List<Nodo<T>> visitati)
        {
            StringBuilder sb = new StringBuilder("Nodi visitati: ");
            foreach (var nodo in visitati)
            {
                sb.Append(nodo.valore + " ");
            }
            MessageBox.Show(sb.ToString());
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbBFS.Text) && !string.IsNullOrWhiteSpace(txbBFS.Text))
            {
                Nodo<string> nodoS;
                Nodo<int> nodoI;
                int n;
                if (tipo)
                {
                    nodoS = grafoS.Trova(txbBFS.Text);
                    if (nodoS != null)
                    {
                        List<Nodo<string>> visitatiS = grafoS.BFS(nodoS);
                        VisualizzaVisitati(visitatiS);
                    }
                    else
                    {
                        MessageBox.Show("Nodo radice non esistente");
                    }
                }
                else
                {
                    if (int.TryParse(txbBFS.Text, out n))
                    {
                        nodoI = grafoI.Trova(n);
                        if (nodoI != null)
                        {
                            List<Nodo<int>> visitatiI = grafoI.BFS(nodoI);
                            VisualizzaVisitati(visitatiI);
                        }
                        else
                        {
                            MessageBox.Show("Nodo radice non esistente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Intero non valido");
                    }
                }
                txbBFS.Clear();
            }
            else
            {
                MessageBox.Show("Nodo radice non valido");
            }
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbDFS.Text) && !string.IsNullOrWhiteSpace(txbDFS.Text))
            {
                Nodo<string> nodoS;
                Nodo<int> nodoI;
                int n;
                if (tipo)
                {
                    nodoS = grafoS.Trova(txbDFS.Text);
                    if (nodoS != null)
                    {
                        List<Nodo<string>> visitatiS = grafoS.DFS(nodoS);
                        VisualizzaVisitati(visitatiS);
                    }
                    else
                    {
                        MessageBox.Show("Nodo radice non esistente");
                    }
                }
                else
                {
                    if (int.TryParse(txbDFS.Text, out n))
                    {
                        nodoI = grafoI.Trova(n);
                        if (nodoI != null)
                        {
                            List<Nodo<int>> visitatiI = grafoI.DFS(nodoI);
                            VisualizzaVisitati(visitatiI);
                        }
                        else
                        {
                            MessageBox.Show("Nodo radice non esistente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Intero non valido");
                    }
                }
                txbDFS.Clear();
            }
            else
            {
                MessageBox.Show("Nodo radice non valido");
            }
        }

        private void btnSommaG_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbSommaG.Text) && !string.IsNullOrWhiteSpace(txbSommaG.Text))
            {
                Nodo<int> nodoI;
                int n, somma = 0;
                if (int.TryParse(txbSommaG.Text, out n))
                {
                    nodoI = grafoI.Trova(n);
                    if (nodoI != null)
                    {
                        List<Nodo<int>> visitatiI = grafoI.BFS(nodoI);
                        foreach (var nodo in visitatiI)
                        {
                            somma += nodo.valore;
                        }
                        MessageBox.Show("La somma dei nodi a partire da " + n + " è " + somma);
                    }
                    else
                    {
                        MessageBox.Show("Nodo radice non esistente");
                    }
                }
                else
                {
                    MessageBox.Show("Intero non valido");
                }
                txbSommaG.Clear();
            }
            else
            {
                MessageBox.Show("Nodo radice non valido");
            }
        }

        private void btnTrovaG_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbTrovaG.Text) && !string.IsNullOrWhiteSpace(txbTrovaG.Text))
            {
                Nodo<string> nodoS;
                nodoS = grafoS.Trova(txbTrovaG.Text);
                if (nodoS != null)
                {
                    List<Nodo<string>> visitatiS = grafoS.BFS(nodoS);
                    string s = nodoS.valore;
                    foreach (var nodo in visitatiS)
                    {
                        if (nodo.valore.Length > s.Length)
                        {
                            s = nodo.valore;
                        }
                    }
                    MessageBox.Show("Il nodo con il nome più lungo a partire da " + txbTrovaG.Text + " è " + s);
                }
                else
                {
                    MessageBox.Show("Nodo radice non esistente");
                }
                txbTrovaG.Clear();
            }
            else
            {
                MessageBox.Show("Nodo radice non valido");
            }
        }

    }
}
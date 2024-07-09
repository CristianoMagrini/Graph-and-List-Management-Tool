namespace Lista
{
    partial class FormLista_Grafo
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btnEsci = new System.Windows.Forms.Button();
            this.rbtnTestaI = new System.Windows.Forms.RadioButton();
            this.rbtnCodaI = new System.Windows.Forms.RadioButton();
            this.rbtnPosizioneI = new System.Windows.Forms.RadioButton();
            this.rbtnOrdineI = new System.Windows.Forms.RadioButton();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.txbValoreI = new System.Windows.Forms.TextBox();
            this.txbPosizioneI = new System.Windows.Forms.TextBox();
            this.lblValoreI = new System.Windows.Forms.Label();
            this.lblPosizioneI = new System.Windows.Forms.Label();
            this.lblPosizioneC = new System.Windows.Forms.Label();
            this.lblValoreC = new System.Windows.Forms.Label();
            this.txbPosizioneC = new System.Windows.Forms.TextBox();
            this.txbValoreC = new System.Windows.Forms.TextBox();
            this.rbtnPosizioneC = new System.Windows.Forms.RadioButton();
            this.rbtnValoreC = new System.Windows.Forms.RadioButton();
            this.pnlInserisci = new System.Windows.Forms.Panel();
            this.lblInserimentoL = new System.Windows.Forms.Label();
            this.pnlCancella = new System.Windows.Forms.Panel();
            this.lblCancellazioneL = new System.Windows.Forms.Label();
            this.btnCancella = new System.Windows.Forms.Button();
            this.tabLista_Grafo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTrovaG = new System.Windows.Forms.Label();
            this.txbTrovaG = new System.Windows.Forms.TextBox();
            this.btnTrovaG = new System.Windows.Forms.Button();
            this.lblSommaG = new System.Windows.Forms.Label();
            this.txbSommaG = new System.Windows.Forms.TextBox();
            this.lblDFS = new System.Windows.Forms.Label();
            this.lblBFS = new System.Windows.Forms.Label();
            this.btnSommaG = new System.Windows.Forms.Button();
            this.txbDFS = new System.Windows.Forms.TextBox();
            this.btnDFS = new System.Windows.Forms.Button();
            this.txbBFS = new System.Windows.Forms.TextBox();
            this.btnBFS = new System.Windows.Forms.Button();
            this.rtxbGrafo = new System.Windows.Forms.RichTextBox();
            this.pnlElimina = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCancellazioneG = new System.Windows.Forms.Label();
            this.btnEliminaA = new System.Windows.Forms.Button();
            this.txbNodoE = new System.Windows.Forms.TextBox();
            this.txbArcoE2 = new System.Windows.Forms.TextBox();
            this.btnEliminaN = new System.Windows.Forms.Button();
            this.txbArcoE1 = new System.Windows.Forms.TextBox();
            this.pnlAggiungi = new System.Windows.Forms.Panel();
            this.lblTra = new System.Windows.Forms.Label();
            this.lblInserimentoG = new System.Windows.Forms.Label();
            this.btnAggiungiA = new System.Windows.Forms.Button();
            this.txbNodoA = new System.Windows.Forms.TextBox();
            this.txbArcoA2 = new System.Windows.Forms.TextBox();
            this.btnAggiungiN = new System.Windows.Forms.Button();
            this.txbArcoA1 = new System.Windows.Forms.TextBox();
            this.pnlTipo = new System.Windows.Forms.Panel();
            this.rbtnString = new System.Windows.Forms.RadioButton();
            this.rbtnInt = new System.Windows.Forms.RadioButton();
            this.pnlInserisci.SuspendLayout();
            this.pnlCancella.SuspendLayout();
            this.tabLista_Grafo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlElimina.SuspendLayout();
            this.pnlAggiungi.SuspendLayout();
            this.pnlTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 16;
            this.lbLista.Location = new System.Drawing.Point(519, 7);
            this.lbLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(624, 404);
            this.lbLista.TabIndex = 5;
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(1063, 496);
            this.btnEsci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(109, 46);
            this.btnEsci.TabIndex = 13;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // rbtnTestaI
            // 
            this.rbtnTestaI.AutoSize = true;
            this.rbtnTestaI.Location = new System.Drawing.Point(205, 68);
            this.rbtnTestaI.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnTestaI.Name = "rbtnTestaI";
            this.rbtnTestaI.Size = new System.Drawing.Size(63, 20);
            this.rbtnTestaI.TabIndex = 14;
            this.rbtnTestaI.TabStop = true;
            this.rbtnTestaI.Text = "Testa";
            this.rbtnTestaI.UseVisualStyleBackColor = true;
            // 
            // rbtnCodaI
            // 
            this.rbtnCodaI.AutoSize = true;
            this.rbtnCodaI.Location = new System.Drawing.Point(205, 96);
            this.rbtnCodaI.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCodaI.Name = "rbtnCodaI";
            this.rbtnCodaI.Size = new System.Drawing.Size(61, 20);
            this.rbtnCodaI.TabIndex = 15;
            this.rbtnCodaI.TabStop = true;
            this.rbtnCodaI.Text = "Coda";
            this.rbtnCodaI.UseVisualStyleBackColor = true;
            // 
            // rbtnPosizioneI
            // 
            this.rbtnPosizioneI.AutoSize = true;
            this.rbtnPosizioneI.Location = new System.Drawing.Point(205, 124);
            this.rbtnPosizioneI.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPosizioneI.Name = "rbtnPosizioneI";
            this.rbtnPosizioneI.Size = new System.Drawing.Size(87, 20);
            this.rbtnPosizioneI.TabIndex = 16;
            this.rbtnPosizioneI.TabStop = true;
            this.rbtnPosizioneI.Text = "Posizione";
            this.rbtnPosizioneI.UseVisualStyleBackColor = true;
            this.rbtnPosizioneI.CheckedChanged += new System.EventHandler(this.rbtnPosizioneI_CheckedChanged);
            // 
            // rbtnOrdineI
            // 
            this.rbtnOrdineI.AutoSize = true;
            this.rbtnOrdineI.Location = new System.Drawing.Point(205, 153);
            this.rbtnOrdineI.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnOrdineI.Name = "rbtnOrdineI";
            this.rbtnOrdineI.Size = new System.Drawing.Size(68, 20);
            this.rbtnOrdineI.TabIndex = 17;
            this.rbtnOrdineI.TabStop = true;
            this.rbtnOrdineI.Text = "Ordine";
            this.rbtnOrdineI.UseVisualStyleBackColor = true;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(347, 112);
            this.btnInserisci.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(100, 28);
            this.btnInserisci.TabIndex = 18;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // txbValoreI
            // 
            this.txbValoreI.Location = new System.Drawing.Point(24, 82);
            this.txbValoreI.Margin = new System.Windows.Forms.Padding(4);
            this.txbValoreI.Name = "txbValoreI";
            this.txbValoreI.Size = new System.Drawing.Size(132, 22);
            this.txbValoreI.TabIndex = 19;
            // 
            // txbPosizioneI
            // 
            this.txbPosizioneI.Location = new System.Drawing.Point(24, 146);
            this.txbPosizioneI.Margin = new System.Windows.Forms.Padding(4);
            this.txbPosizioneI.Name = "txbPosizioneI";
            this.txbPosizioneI.Size = new System.Drawing.Size(132, 22);
            this.txbPosizioneI.TabIndex = 20;
            // 
            // lblValoreI
            // 
            this.lblValoreI.AutoSize = true;
            this.lblValoreI.Location = new System.Drawing.Point(68, 63);
            this.lblValoreI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValoreI.Name = "lblValoreI";
            this.lblValoreI.Size = new System.Drawing.Size(47, 16);
            this.lblValoreI.TabIndex = 21;
            this.lblValoreI.Text = "Valore";
            // 
            // lblPosizioneI
            // 
            this.lblPosizioneI.AutoSize = true;
            this.lblPosizioneI.Location = new System.Drawing.Point(53, 124);
            this.lblPosizioneI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosizioneI.Name = "lblPosizioneI";
            this.lblPosizioneI.Size = new System.Drawing.Size(66, 16);
            this.lblPosizioneI.TabIndex = 22;
            this.lblPosizioneI.Text = "Posizione";
            // 
            // lblPosizioneC
            // 
            this.lblPosizioneC.AutoSize = true;
            this.lblPosizioneC.Location = new System.Drawing.Point(53, 118);
            this.lblPosizioneC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosizioneC.Name = "lblPosizioneC";
            this.lblPosizioneC.Size = new System.Drawing.Size(66, 16);
            this.lblPosizioneC.TabIndex = 26;
            this.lblPosizioneC.Text = "Posizione";
            // 
            // lblValoreC
            // 
            this.lblValoreC.AutoSize = true;
            this.lblValoreC.Location = new System.Drawing.Point(68, 57);
            this.lblValoreC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValoreC.Name = "lblValoreC";
            this.lblValoreC.Size = new System.Drawing.Size(47, 16);
            this.lblValoreC.TabIndex = 25;
            this.lblValoreC.Text = "Valore";
            // 
            // txbPosizioneC
            // 
            this.txbPosizioneC.Location = new System.Drawing.Point(24, 140);
            this.txbPosizioneC.Margin = new System.Windows.Forms.Padding(4);
            this.txbPosizioneC.Name = "txbPosizioneC";
            this.txbPosizioneC.Size = new System.Drawing.Size(132, 22);
            this.txbPosizioneC.TabIndex = 24;
            // 
            // txbValoreC
            // 
            this.txbValoreC.Location = new System.Drawing.Point(24, 76);
            this.txbValoreC.Margin = new System.Windows.Forms.Padding(4);
            this.txbValoreC.Name = "txbValoreC";
            this.txbValoreC.Size = new System.Drawing.Size(132, 22);
            this.txbValoreC.TabIndex = 23;
            // 
            // rbtnPosizioneC
            // 
            this.rbtnPosizioneC.AutoSize = true;
            this.rbtnPosizioneC.Location = new System.Drawing.Point(205, 119);
            this.rbtnPosizioneC.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPosizioneC.Name = "rbtnPosizioneC";
            this.rbtnPosizioneC.Size = new System.Drawing.Size(87, 20);
            this.rbtnPosizioneC.TabIndex = 28;
            this.rbtnPosizioneC.TabStop = true;
            this.rbtnPosizioneC.Text = "Posizione";
            this.rbtnPosizioneC.UseVisualStyleBackColor = true;
            this.rbtnPosizioneC.CheckedChanged += new System.EventHandler(this.rbtnPosizioneC_CheckedChanged);
            // 
            // rbtnValoreC
            // 
            this.rbtnValoreC.AutoSize = true;
            this.rbtnValoreC.Location = new System.Drawing.Point(205, 91);
            this.rbtnValoreC.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnValoreC.Name = "rbtnValoreC";
            this.rbtnValoreC.Size = new System.Drawing.Size(68, 20);
            this.rbtnValoreC.TabIndex = 27;
            this.rbtnValoreC.TabStop = true;
            this.rbtnValoreC.Text = "Valore";
            this.rbtnValoreC.UseVisualStyleBackColor = true;
            this.rbtnValoreC.CheckedChanged += new System.EventHandler(this.rbtnValoreC_CheckedChanged);
            // 
            // pnlInserisci
            // 
            this.pnlInserisci.Controls.Add(this.lblInserimentoL);
            this.pnlInserisci.Controls.Add(this.lblPosizioneI);
            this.pnlInserisci.Controls.Add(this.lblValoreI);
            this.pnlInserisci.Controls.Add(this.txbPosizioneI);
            this.pnlInserisci.Controls.Add(this.txbValoreI);
            this.pnlInserisci.Controls.Add(this.btnInserisci);
            this.pnlInserisci.Controls.Add(this.rbtnOrdineI);
            this.pnlInserisci.Controls.Add(this.rbtnPosizioneI);
            this.pnlInserisci.Controls.Add(this.rbtnCodaI);
            this.pnlInserisci.Controls.Add(this.rbtnTestaI);
            this.pnlInserisci.Location = new System.Drawing.Point(7, 7);
            this.pnlInserisci.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInserisci.Name = "pnlInserisci";
            this.pnlInserisci.Size = new System.Drawing.Size(493, 193);
            this.pnlInserisci.TabIndex = 29;
            // 
            // lblInserimentoL
            // 
            this.lblInserimentoL.AutoSize = true;
            this.lblInserimentoL.Location = new System.Drawing.Point(189, 28);
            this.lblInserimentoL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInserimentoL.Name = "lblInserimentoL";
            this.lblInserimentoL.Size = new System.Drawing.Size(100, 16);
            this.lblInserimentoL.TabIndex = 31;
            this.lblInserimentoL.Text = "INSERIMENTO";
            // 
            // pnlCancella
            // 
            this.pnlCancella.Controls.Add(this.lblCancellazioneL);
            this.pnlCancella.Controls.Add(this.btnCancella);
            this.pnlCancella.Controls.Add(this.rbtnPosizioneC);
            this.pnlCancella.Controls.Add(this.rbtnValoreC);
            this.pnlCancella.Controls.Add(this.lblPosizioneC);
            this.pnlCancella.Controls.Add(this.lblValoreC);
            this.pnlCancella.Controls.Add(this.txbPosizioneC);
            this.pnlCancella.Controls.Add(this.txbValoreC);
            this.pnlCancella.Location = new System.Drawing.Point(7, 218);
            this.pnlCancella.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCancella.Name = "pnlCancella";
            this.pnlCancella.Size = new System.Drawing.Size(492, 193);
            this.pnlCancella.TabIndex = 30;
            // 
            // lblCancellazioneL
            // 
            this.lblCancellazioneL.AutoSize = true;
            this.lblCancellazioneL.Location = new System.Drawing.Point(189, 33);
            this.lblCancellazioneL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancellazioneL.Name = "lblCancellazioneL";
            this.lblCancellazioneL.Size = new System.Drawing.Size(116, 16);
            this.lblCancellazioneL.TabIndex = 32;
            this.lblCancellazioneL.Text = "CANCELLAZIONE";
            // 
            // btnCancella
            // 
            this.btnCancella.Location = new System.Drawing.Point(351, 106);
            this.btnCancella.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(100, 28);
            this.btnCancella.TabIndex = 23;
            this.btnCancella.Text = "Cancella";
            this.btnCancella.UseVisualStyleBackColor = true;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // tabLista_Grafo
            // 
            this.tabLista_Grafo.Controls.Add(this.tabPage1);
            this.tabLista_Grafo.Controls.Add(this.tabPage2);
            this.tabLista_Grafo.Location = new System.Drawing.Point(16, 43);
            this.tabLista_Grafo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLista_Grafo.Name = "tabLista_Grafo";
            this.tabLista_Grafo.SelectedIndex = 0;
            this.tabLista_Grafo.Size = new System.Drawing.Size(1160, 447);
            this.tabLista_Grafo.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlInserisci);
            this.tabPage1.Controls.Add(this.pnlCancella);
            this.tabPage1.Controls.Add(this.lbLista);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1152, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LISTA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTrovaG);
            this.tabPage2.Controls.Add(this.txbTrovaG);
            this.tabPage2.Controls.Add(this.btnTrovaG);
            this.tabPage2.Controls.Add(this.lblSommaG);
            this.tabPage2.Controls.Add(this.txbSommaG);
            this.tabPage2.Controls.Add(this.lblDFS);
            this.tabPage2.Controls.Add(this.lblBFS);
            this.tabPage2.Controls.Add(this.btnSommaG);
            this.tabPage2.Controls.Add(this.txbDFS);
            this.tabPage2.Controls.Add(this.btnDFS);
            this.tabPage2.Controls.Add(this.txbBFS);
            this.tabPage2.Controls.Add(this.btnBFS);
            this.tabPage2.Controls.Add(this.rtxbGrafo);
            this.tabPage2.Controls.Add(this.pnlElimina);
            this.tabPage2.Controls.Add(this.pnlAggiungi);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1152, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GRAFO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTrovaG
            // 
            this.lblTrovaG.AutoSize = true;
            this.lblTrovaG.Location = new System.Drawing.Point(875, 318);
            this.lblTrovaG.Name = "lblTrovaG";
            this.lblTrovaG.Size = new System.Drawing.Size(82, 16);
            this.lblTrovaG.TabIndex = 45;
            this.lblTrovaG.Text = "Nodo radice";
            // 
            // txbTrovaG
            // 
            this.txbTrovaG.Location = new System.Drawing.Point(866, 337);
            this.txbTrovaG.Margin = new System.Windows.Forms.Padding(4);
            this.txbTrovaG.Name = "txbTrovaG";
            this.txbTrovaG.Size = new System.Drawing.Size(104, 22);
            this.txbTrovaG.TabIndex = 44;
            // 
            // btnTrovaG
            // 
            this.btnTrovaG.Location = new System.Drawing.Point(977, 318);
            this.btnTrovaG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrovaG.Name = "btnTrovaG";
            this.btnTrovaG.Size = new System.Drawing.Size(165, 57);
            this.btnTrovaG.TabIndex = 43;
            this.btnTrovaG.Text = "Trova il Nodo con il Nome più Lungo";
            this.btnTrovaG.UseVisualStyleBackColor = true;
            this.btnTrovaG.Click += new System.EventHandler(this.btnTrovaG_Click);
            // 
            // lblSommaG
            // 
            this.lblSommaG.AutoSize = true;
            this.lblSommaG.Location = new System.Drawing.Point(875, 225);
            this.lblSommaG.Name = "lblSommaG";
            this.lblSommaG.Size = new System.Drawing.Size(82, 16);
            this.lblSommaG.TabIndex = 42;
            this.lblSommaG.Text = "Nodo radice";
            // 
            // txbSommaG
            // 
            this.txbSommaG.Location = new System.Drawing.Point(866, 244);
            this.txbSommaG.Margin = new System.Windows.Forms.Padding(4);
            this.txbSommaG.Name = "txbSommaG";
            this.txbSommaG.Size = new System.Drawing.Size(104, 22);
            this.txbSommaG.TabIndex = 41;
            // 
            // lblDFS
            // 
            this.lblDFS.AutoSize = true;
            this.lblDFS.Location = new System.Drawing.Point(874, 137);
            this.lblDFS.Name = "lblDFS";
            this.lblDFS.Size = new System.Drawing.Size(82, 16);
            this.lblDFS.TabIndex = 40;
            this.lblDFS.Text = "Nodo radice";
            // 
            // lblBFS
            // 
            this.lblBFS.AutoSize = true;
            this.lblBFS.Location = new System.Drawing.Point(875, 51);
            this.lblBFS.Name = "lblBFS";
            this.lblBFS.Size = new System.Drawing.Size(82, 16);
            this.lblBFS.TabIndex = 39;
            this.lblBFS.Text = "Nodo radice";
            // 
            // btnSommaG
            // 
            this.btnSommaG.Location = new System.Drawing.Point(977, 223);
            this.btnSommaG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSommaG.Name = "btnSommaG";
            this.btnSommaG.Size = new System.Drawing.Size(165, 57);
            this.btnSommaG.TabIndex = 36;
            this.btnSommaG.Text = "Somma i Nodi del Grafo";
            this.btnSommaG.UseVisualStyleBackColor = true;
            this.btnSommaG.Click += new System.EventHandler(this.btnSommaG_Click);
            // 
            // txbDFS
            // 
            this.txbDFS.Location = new System.Drawing.Point(865, 157);
            this.txbDFS.Margin = new System.Windows.Forms.Padding(4);
            this.txbDFS.Name = "txbDFS";
            this.txbDFS.Size = new System.Drawing.Size(104, 22);
            this.txbDFS.TabIndex = 37;
            // 
            // btnDFS
            // 
            this.btnDFS.Location = new System.Drawing.Point(977, 137);
            this.btnDFS.Margin = new System.Windows.Forms.Padding(4);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(165, 55);
            this.btnDFS.TabIndex = 38;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = true;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // txbBFS
            // 
            this.txbBFS.Location = new System.Drawing.Point(865, 71);
            this.txbBFS.Margin = new System.Windows.Forms.Padding(4);
            this.txbBFS.Name = "txbBFS";
            this.txbBFS.Size = new System.Drawing.Size(104, 22);
            this.txbBFS.TabIndex = 34;
            // 
            // btnBFS
            // 
            this.btnBFS.Location = new System.Drawing.Point(977, 51);
            this.btnBFS.Margin = new System.Windows.Forms.Padding(4);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(165, 57);
            this.btnBFS.TabIndex = 36;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // rtxbGrafo
            // 
            this.rtxbGrafo.Location = new System.Drawing.Point(523, 6);
            this.rtxbGrafo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxbGrafo.Name = "rtxbGrafo";
            this.rtxbGrafo.Size = new System.Drawing.Size(337, 406);
            this.rtxbGrafo.TabIndex = 35;
            this.rtxbGrafo.Text = "";
            // 
            // pnlElimina
            // 
            this.pnlElimina.Controls.Add(this.label2);
            this.pnlElimina.Controls.Add(this.lblCancellazioneG);
            this.pnlElimina.Controls.Add(this.btnEliminaA);
            this.pnlElimina.Controls.Add(this.txbNodoE);
            this.pnlElimina.Controls.Add(this.txbArcoE2);
            this.pnlElimina.Controls.Add(this.btnEliminaN);
            this.pnlElimina.Controls.Add(this.txbArcoE1);
            this.pnlElimina.Location = new System.Drawing.Point(7, 219);
            this.pnlElimina.Margin = new System.Windows.Forms.Padding(4);
            this.pnlElimina.Name = "pnlElimina";
            this.pnlElimina.Size = new System.Drawing.Size(495, 193);
            this.pnlElimina.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "->";
            // 
            // lblCancellazioneG
            // 
            this.lblCancellazioneG.AutoSize = true;
            this.lblCancellazioneG.Location = new System.Drawing.Point(191, 27);
            this.lblCancellazioneG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancellazioneG.Name = "lblCancellazioneG";
            this.lblCancellazioneG.Size = new System.Drawing.Size(116, 16);
            this.lblCancellazioneG.TabIndex = 31;
            this.lblCancellazioneG.Text = "CANCELLAZIONE";
            // 
            // btnEliminaA
            // 
            this.btnEliminaA.Location = new System.Drawing.Point(181, 113);
            this.btnEliminaA.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminaA.Name = "btnEliminaA";
            this.btnEliminaA.Size = new System.Drawing.Size(296, 28);
            this.btnEliminaA.TabIndex = 33;
            this.btnEliminaA.Text = "Elimina Arco";
            this.btnEliminaA.UseVisualStyleBackColor = true;
            this.btnEliminaA.Click += new System.EventHandler(this.btnEliminaA_Click);
            // 
            // txbNodoE
            // 
            this.txbNodoE.Location = new System.Drawing.Point(17, 81);
            this.txbNodoE.Margin = new System.Windows.Forms.Padding(4);
            this.txbNodoE.Name = "txbNodoE";
            this.txbNodoE.Size = new System.Drawing.Size(132, 22);
            this.txbNodoE.TabIndex = 19;
            // 
            // txbArcoE2
            // 
            this.txbArcoE2.Location = new System.Drawing.Point(344, 81);
            this.txbArcoE2.Margin = new System.Windows.Forms.Padding(4);
            this.txbArcoE2.Name = "txbArcoE2";
            this.txbArcoE2.Size = new System.Drawing.Size(132, 22);
            this.txbArcoE2.TabIndex = 32;
            // 
            // btnEliminaN
            // 
            this.btnEliminaN.Location = new System.Drawing.Point(20, 113);
            this.btnEliminaN.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminaN.Name = "btnEliminaN";
            this.btnEliminaN.Size = new System.Drawing.Size(131, 28);
            this.btnEliminaN.TabIndex = 18;
            this.btnEliminaN.Text = "Elimina Nodo";
            this.btnEliminaN.UseVisualStyleBackColor = true;
            this.btnEliminaN.Click += new System.EventHandler(this.btnEliminaN_Click);
            // 
            // txbArcoE1
            // 
            this.txbArcoE1.Location = new System.Drawing.Point(181, 81);
            this.txbArcoE1.Margin = new System.Windows.Forms.Padding(4);
            this.txbArcoE1.Name = "txbArcoE1";
            this.txbArcoE1.Size = new System.Drawing.Size(132, 22);
            this.txbArcoE1.TabIndex = 20;
            // 
            // pnlAggiungi
            // 
            this.pnlAggiungi.Controls.Add(this.lblTra);
            this.pnlAggiungi.Controls.Add(this.lblInserimentoG);
            this.pnlAggiungi.Controls.Add(this.btnAggiungiA);
            this.pnlAggiungi.Controls.Add(this.txbNodoA);
            this.pnlAggiungi.Controls.Add(this.txbArcoA2);
            this.pnlAggiungi.Controls.Add(this.btnAggiungiN);
            this.pnlAggiungi.Controls.Add(this.txbArcoA1);
            this.pnlAggiungi.Location = new System.Drawing.Point(7, 6);
            this.pnlAggiungi.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAggiungi.Name = "pnlAggiungi";
            this.pnlAggiungi.Size = new System.Drawing.Size(495, 193);
            this.pnlAggiungi.TabIndex = 30;
            // 
            // lblTra
            // 
            this.lblTra.AutoSize = true;
            this.lblTra.Location = new System.Drawing.Point(321, 84);
            this.lblTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(18, 16);
            this.lblTra.TabIndex = 32;
            this.lblTra.Text = "->";
            // 
            // lblInserimentoG
            // 
            this.lblInserimentoG.AutoSize = true;
            this.lblInserimentoG.Location = new System.Drawing.Point(191, 27);
            this.lblInserimentoG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInserimentoG.Name = "lblInserimentoG";
            this.lblInserimentoG.Size = new System.Drawing.Size(100, 16);
            this.lblInserimentoG.TabIndex = 31;
            this.lblInserimentoG.Text = "INSERIMENTO";
            // 
            // btnAggiungiA
            // 
            this.btnAggiungiA.Location = new System.Drawing.Point(181, 113);
            this.btnAggiungiA.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggiungiA.Name = "btnAggiungiA";
            this.btnAggiungiA.Size = new System.Drawing.Size(296, 28);
            this.btnAggiungiA.TabIndex = 33;
            this.btnAggiungiA.Text = "Aggiungi Arco";
            this.btnAggiungiA.UseVisualStyleBackColor = true;
            this.btnAggiungiA.Click += new System.EventHandler(this.btnAggiungiA_Click);
            // 
            // txbNodoA
            // 
            this.txbNodoA.Location = new System.Drawing.Point(17, 81);
            this.txbNodoA.Margin = new System.Windows.Forms.Padding(4);
            this.txbNodoA.Name = "txbNodoA";
            this.txbNodoA.Size = new System.Drawing.Size(132, 22);
            this.txbNodoA.TabIndex = 19;
            // 
            // txbArcoA2
            // 
            this.txbArcoA2.Location = new System.Drawing.Point(344, 81);
            this.txbArcoA2.Margin = new System.Windows.Forms.Padding(4);
            this.txbArcoA2.Name = "txbArcoA2";
            this.txbArcoA2.Size = new System.Drawing.Size(132, 22);
            this.txbArcoA2.TabIndex = 32;
            // 
            // btnAggiungiN
            // 
            this.btnAggiungiN.Location = new System.Drawing.Point(20, 113);
            this.btnAggiungiN.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggiungiN.Name = "btnAggiungiN";
            this.btnAggiungiN.Size = new System.Drawing.Size(131, 28);
            this.btnAggiungiN.TabIndex = 18;
            this.btnAggiungiN.Text = "Aggiungi Nodo";
            this.btnAggiungiN.UseVisualStyleBackColor = true;
            this.btnAggiungiN.Click += new System.EventHandler(this.btnAggiungiN_Click);
            // 
            // txbArcoA1
            // 
            this.txbArcoA1.Location = new System.Drawing.Point(181, 81);
            this.txbArcoA1.Margin = new System.Windows.Forms.Padding(4);
            this.txbArcoA1.Name = "txbArcoA1";
            this.txbArcoA1.Size = new System.Drawing.Size(132, 22);
            this.txbArcoA1.TabIndex = 20;
            // 
            // pnlTipo
            // 
            this.pnlTipo.Controls.Add(this.rbtnString);
            this.pnlTipo.Controls.Add(this.rbtnInt);
            this.pnlTipo.Location = new System.Drawing.Point(997, 12);
            this.pnlTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTipo.Name = "pnlTipo";
            this.pnlTipo.Size = new System.Drawing.Size(179, 50);
            this.pnlTipo.TabIndex = 33;
            // 
            // rbtnString
            // 
            this.rbtnString.AutoSize = true;
            this.rbtnString.Location = new System.Drawing.Point(95, 14);
            this.rbtnString.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnString.Name = "rbtnString";
            this.rbtnString.Size = new System.Drawing.Size(77, 20);
            this.rbtnString.TabIndex = 35;
            this.rbtnString.Text = "Stringhe";
            this.rbtnString.UseVisualStyleBackColor = true;
            this.rbtnString.CheckedChanged += new System.EventHandler(this.rbtnString_CheckedChanged);
            // 
            // rbtnInt
            // 
            this.rbtnInt.AutoSize = true;
            this.rbtnInt.Checked = true;
            this.rbtnInt.Location = new System.Drawing.Point(7, 14);
            this.rbtnInt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnInt.Name = "rbtnInt";
            this.rbtnInt.Size = new System.Drawing.Size(56, 20);
            this.rbtnInt.TabIndex = 34;
            this.rbtnInt.TabStop = true;
            this.rbtnInt.Text = "Interi";
            this.rbtnInt.UseVisualStyleBackColor = true;
            this.rbtnInt.CheckedChanged += new System.EventHandler(this.rbtnInt_CheckedChanged);
            // 
            // FormLista_Grafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 553);
            this.Controls.Add(this.pnlTipo);
            this.Controls.Add(this.tabLista_Grafo);
            this.Controls.Add(this.btnEsci);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLista_Grafo";
            this.Text = "Lista e Grafo";
            this.Load += new System.EventHandler(this.FormLista_Grafo_Load);
            this.pnlInserisci.ResumeLayout(false);
            this.pnlInserisci.PerformLayout();
            this.pnlCancella.ResumeLayout(false);
            this.pnlCancella.PerformLayout();
            this.tabLista_Grafo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlElimina.ResumeLayout(false);
            this.pnlElimina.PerformLayout();
            this.pnlAggiungi.ResumeLayout(false);
            this.pnlAggiungi.PerformLayout();
            this.pnlTipo.ResumeLayout(false);
            this.pnlTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.RadioButton rbtnTestaI;
        private System.Windows.Forms.RadioButton rbtnCodaI;
        private System.Windows.Forms.RadioButton rbtnPosizioneI;
        private System.Windows.Forms.RadioButton rbtnOrdineI;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.TextBox txbValoreI;
        private System.Windows.Forms.TextBox txbPosizioneI;
        private System.Windows.Forms.Label lblValoreI;
        private System.Windows.Forms.Label lblPosizioneI;
        private System.Windows.Forms.Label lblPosizioneC;
        private System.Windows.Forms.Label lblValoreC;
        private System.Windows.Forms.TextBox txbPosizioneC;
        private System.Windows.Forms.TextBox txbValoreC;
        private System.Windows.Forms.RadioButton rbtnPosizioneC;
        private System.Windows.Forms.RadioButton rbtnValoreC;
        private System.Windows.Forms.Panel pnlInserisci;
        private System.Windows.Forms.Panel pnlCancella;
        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.Label lblInserimentoL;
        private System.Windows.Forms.Label lblCancellazioneL;
        private System.Windows.Forms.TabControl tabLista_Grafo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlAggiungi;
        private System.Windows.Forms.Label lblInserimentoG;
        private System.Windows.Forms.TextBox txbArcoA1;
        private System.Windows.Forms.TextBox txbNodoA;
        private System.Windows.Forms.Button btnAggiungiN;
        private System.Windows.Forms.Button btnAggiungiA;
        private System.Windows.Forms.TextBox txbArcoA2;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.Panel pnlElimina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCancellazioneG;
        private System.Windows.Forms.Button btnEliminaA;
        private System.Windows.Forms.TextBox txbNodoE;
        private System.Windows.Forms.TextBox txbArcoE2;
        private System.Windows.Forms.Button btnEliminaN;
        private System.Windows.Forms.TextBox txbArcoE1;
        private System.Windows.Forms.Panel pnlTipo;
        private System.Windows.Forms.RadioButton rbtnString;
        private System.Windows.Forms.RadioButton rbtnInt;
        private System.Windows.Forms.RichTextBox rtxbGrafo;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.TextBox txbBFS;
        private System.Windows.Forms.TextBox txbDFS;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnSommaG;
        private System.Windows.Forms.Label lblSommaG;
        private System.Windows.Forms.TextBox txbSommaG;
        private System.Windows.Forms.Label lblDFS;
        private System.Windows.Forms.Label lblBFS;
        private System.Windows.Forms.Label lblTrovaG;
        private System.Windows.Forms.TextBox txbTrovaG;
        private System.Windows.Forms.Button btnTrovaG;
    }
}


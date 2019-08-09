using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AldoGiovanniGiacomo.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 50, nullable: false),
                    Nickname = table.Column<string>(maxLength: 50, nullable: true),
                    Birth = table.Column<DateTime>(nullable: false),
                    BirthPlace = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: false),
                    ActorId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotes_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quotes_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Birth", "BirthPlace", "Name", "Nickname", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(1958, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Palermo", "Aldo", null, "Baglio" },
                    { 2, new DateTime(1957, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milano", "Giovanni", null, "Storti" },
                    { 3, new DateTime(1956, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Villa Cortese", "Giacomo", "Giacomino", "Poretti" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Aldo Baglio, Giovanni Storti, Giacomo Poretti, Massimo Venier", "Tre uomini e una gamba", 1997 },
                    { 2, "Aldo Baglio, Giovanni Storti, Giacomo Poretti, Massimo Venier", "Così è la vita", 1998 },
                    { 3, "Paolo Costella", "Tutti gli uomini del deficiente", 1999 },
                    { 4, "Aldo Baglio, Giovanni Storti, Giacomo Poretti, Massimo Venier", "Chiedimi se sono felice", 2000 },
                    { 5, "Aldo Baglio, Giovanni Storti, Giacomo Poretti, Massimo Venier", "La leggenda di Al, John e Jack", 2002 },
                    { 6, "Massimo Venier", "Tu la conosci Claudia?", 2004 },
                    { 7, "Arturo Brachetti, Rinaldo Gaspari", "Anplagghed al cinema", 2006 },
                    { 8, "Marcello Cesena", "Il cosmo sul comò", 2008 },
                    { 9, "Paolo Genovese", "La banda dei Babbi Natale", 2010 },
                    { 10, "Arturo Brachetti", "Ammutta mudica al cinema", 2013 },
                    { 11, "Aldo Baglio, Giovanni Storti, Giacomo Poretti, Morgan Bertacca", "Il ricco, il povero e il maggiordomo", 2014 },
                    { 12, "Aldo Baglio, Giovanni Storti, Giacomo Poretti, Morgan Bertacca", "Fuga da Reuma Park", 2016 }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "ActorId", "Content", "MovieId" },
                values: new object[,]
                {
                    { 1, 1, "[Leggendo le istruzioni di montaggio del fucile, allontana Jack] Tenere lontano dalla portata dei bambini...", 1 },
                    { 36, 2, "Giacomo, guarda, parlare con te o parlare con Biscardi è la stessa cosa...", 4 },
                    { 37, 1, "Ma possibile che come ti muovi pesti una merda? In un colpo solo gli hai fatto fuori il lavoro e la fidanzata! Adesso prendi una macchina, gli metti sotto la madre e finisci il lavoro. E comunque Giacomino se ti chiedo un favore, domani, non farmelo!", 4 },
                    { 38, 2, "Aldo, non è che perché hai un frigo degli anni '60 ci devi tener dentro la roba degli anni '60!", 4 },
                    { 39, 2, "Ma che cosa cazzo me ne frega di cosa avete bevuto?? Piuttosto dimmi cosa ti ha detto! [Aldo accende lo stereo] Ma la vuoi spegnere quella merda di musica o no??", 4 },
                    { 40, 1, "Per favore, lascia stare... Giacomino, vattene, lasciami solo. [dopo la furibonda rabbia di Giovanni che ha distrutto tutta la scenografia]", 4 },
                    { 41, 1, "Avete presente la teoria del piano inclinato? No? Ve la spiego. Se mettete una pallina su un piano inclinato la pallina comincia a scendere, e per quanto impercettibile sia l'inclinazione, inizia a correre e correre sempre più veloce. Fermarla, è impossibile. Ma per fortuna gli uomini non sono palline: basta un gesto, un'occhiata, una frase qualsiasi a fermare il corso delle cose.", 4 },
                    { 42, 1, "E voi chi minchia siete?", 5 },
                    { 43, 2, "Tanti auguri a Jack | Tanti auguri a Jack | Tanti auguri impasticcomane! | Tanti auguri a te!", 5 },
                    { 44, 3, "Anzi fai una cosa, Johnny: ammazzalo così la smette di soffrire, va! [riferito ad Al che ha perso la memoria]", 5 },
                    { 45, 3, "Johnny, Johnny, non piangere, che diventi brutto!", 5 },
                    { 46, 2, "Le ha spente con la tosse... [le candeline] [riferito a Jack e alla sua salute 'non proprio di ferro']", 5 },
                    { 47, 3, "Ma quant'è bella la mafia!", 5 },
                    { 48, 2, "Buongiorno signora e benvenuta. È un piacere accoglierLa in questa città di New York, città bellissima ma non altrettanto che Lei. [John, che si studia il benvenuto da fare alla zia del boss Genovese che è in arrivo a New York]", 5 },
                    { 35, 1, "Giacomino, ti prego, scarricamela!", 4 },
                    { 49, 2, "Jack, noi stiamo mettendo la nostra vita nelle sue mani e questo non sa neanche come si chiama!  [riferito ad Al, che aveva appena detto di chiamarsi Niccolò Carosio]", 5 },
                    { 51, 2, "Che tocchi? Che tocchi, Jack? Non è roba per te! Non hai mai avuto manualità!", 5 },
                    { 52, 1, "E vedi di non farmi diventare Al tre dita. [riferito a Jack che attacca un quadro con la pistola]", 5 },
                    { 53, 1, "Senta, io mi prendo le mie responsabilità, ma siamo sicuri che il chiosco non sia abusivo? [dopo aver investito una bancarella]", 6 },
                    { 54, 1, "Ma proprio adesso che mi stavo innamorando, che ero deciso di fare il passo più lungo della gamba! Io lo so quando è crollato tutto: è stato quel maledetto momento in cui abbiamo visto insieme il marito! [piangendo]", 6 },
                    { 55, 1, "Claudia non esiste, suo marito non esiste! Claudia non esiste, suo marito non esiste!", 6 },
                    { 56, 2, "Senti, 'NonSoloTaxi', ma come guidi? Porca puttana, va' come hai conciato la macchina... Allora, di constatazione amichevole non ne parliamo neanche, eh, tanto nessun giudice ti darebbe ragione! [dopo aver tamponato Aldo]", 6 },
                    { 57, 1, "C'è un posto dove posso vomitare un attimo? Un posto specifico per il vomito, insomma: un vomituario, anche di modeste proporzioni.", 6 },
                    { 58, 1, "Se queste mura potessero parlare, si dovrebbero confessare! Fuochi! Fiamme! Sodoma! Gamarra! Eh?", 6 },
                    { 59, 1, "Miiii, che bello! Unplugged!", 6 },
                    { 60, 2, "Allora lo vogliamo far smettere di piangere 'sto bambino o no, eh? Sono le tre di notte! [più furioso di prima] Li vogliamo spendere 'sti due soldi per farlo visitare da uno specialista o no, eh? Ve ne consiglio uno: Dott. Sirchioli. 6832173! [sempre più infuriato] Cosa faccio, chiamo i carabinieri, eh??? [sentendo il bambino dei vicini che piange forte]", 6 },
                    { 61, 2, "[Ad Aldo, che indossa una camicia a fiori] Ma come sei vestito? Stai andando al Carnevale di Venezia? Sembri Brighella con le scarpe di Pantalone!", 8 },
                    { 62, 1, "Equilibre, equilibre, equlibre...", 8 },
                    { 63, 2, "Scivolement, scivolement, scivolement...", 8 },
                    { 50, 3, "Johnny, a te te lo devono dare il premio Nobel per la mafia, e se non te lo danno è perché è tutto un magna magna.", 5 },
                    { 34, 1, "Perché l'amore, quando ci si mette, è veramente bastardo.", 4 },
                    { 33, 2, "Anche mia nonna quando doveva mettermi le supposte da bambino me le spalmava sul sellino della bicicletta!", 4 },
                    { 32, 2, "Ma cosa c'hai nel cervello? Le scimmie urlatrici?", 4 },
                    { 2, 2, "[Dopo che Chiara propone di fare un bagno in un lago] No eh, ragazzi, simpatia, va bene, si scherza, si gioca, gli ho fatto anche guidare la macchina, però siamo già in ritardo! Non scherziamo... [si gira e non vede più nessuno in macchina] Va bene. Ma solo cinque minuti!", 1 },
                    { 3, 2, "Ma hai visto quel cane lì? Gli hanno montato... le tibie al contrario? [riferito al bulldog Ringhio]", 1 },
                    { 4, 2, "[Dando istruzioni ad Aldo su come sistemare il pacco nel bagagliaio] Dai, mettila bene... Mettila più dritta! Mettilo fino in fondo... Sdraiato però, mettilo piatto! Piatto! Metti che succede qualcosa, mettilo piatto!", 1 },
                    { 5, 2, "Un latte macchiato tiepido, senza schiuma e con poco caffè... tiepido, eh, non freddo! Poi gli chiedi le cose... [al bar, poco dopo gli viene servito il latte] Freddo, lo sapevo io!", 1 },
                    { 7, 2, "Mattone polacco minimalista di scrittore morto suicida giovanissimo! Copie vendute: due. [parlando del libro che sta comprando Giacomo]", 1 },
                    { 8, 2, "Ma vai! Ma vieni! Ma chi sono? Eh, pirletti, dimmi, chi sono? Altro che la tua ruota! [vede il padre dei bambini che lo guarda storto] Chi arriva ultimo [all'auto] è pirla!", 1 },
                    { 9, 2, "Anche il capitano del Titanic lo diceva: 'Ma no, ma no, è solo un rumorino! Da niente!' [riferito ad un rumore proveniente dalla macchina]", 1 },
                    { 10, 2, "Sì, ma a te bisogna portarti in giro legato... [riferito a Aldo che fa cadere per la seconda volta i barattoli davanti all'officina del meccanico]", 1 },
                    { 11, 1, "A volte dorme di più lo sveglio che il dormiente!", 1 },
                    { 12, 1, "Una rondine non vola solo e sempre a primavera.", 1 },
                    { 13, 2, "Ma vieni! Jair! È il ritorno della Grande Inter! È il ritorno! [dopo aver segnato un bel gol in 'Italia-Marocco']", 1 },
                    { 14, 2, "Questo qui [Giacomo] si deve sposare e siamo in ritardo di una vita... il dietro della macchina... completamente sfasciato... ci ha affidato un bulldog e gli [al suocero] riportiamo... un toporagno... e una gamba da trecento milioni è in mano a una banda di muratori marocchini! Ditemi voi... ", 1 },
                    { 15, 1, "[Al telefono, chiama il suocero] Pronto, pronto sì, ssss sì ssì sssss stiamo, siam... sìsìsì no, è... la la lascia lasciami... è m mma maria nnn... noo... ss, bè, ss se fosse stato per me... sì... ma io ss sono il primo che che... non ho ca, non ho ca, non ho c... non ho c... [urlando stressato] Allora, mi lasci parlare o no?! Hai capito?! E non ne posso più di ascoltarti, stai parlando solo tu! E mi hai proprio rotto i coglioni, mi hai rotto i coglioni, hai capito?! Perché non sono un automa, sono una persona, e a un certo punto te lo devo proprio dire: vaffanculo! Vaffanculo!! V, A, F, F, 'ncuuuulo!!! Tu, il tuo negozio, la tua villa di merda, mi fai schifo, strooonzoo!! [chiude furiosamente la chiamata e gli altri lo guardano colpiti] Era occupato.", 1 },
                    { 16, 1, "Giacomino è in bagno... Giacomino sta dormendo... eh sì... sta dormendo in bagno... eh, si vede che si è addormentato mentre stava cagando! Che ne so io! Stiamo arrivando! Sì! Ma stiamo arriva... ma... [Aldo da un'occhiata crudele al cellulare mentre Giuliana ancora blatera] Ma vaffancuuulo! [Aldo getta furiosamente il cellulare in mare dopo essere stato stressato da Giuliana, e Giovanni e Giacomo lo guardano colpiti]", 1 },
                    { 17, 2, "[Dopo avergli sparato un proiettile in una gamba] Ma non fare polemiche, Jack, ha rimbalzato!", 2 },
                    { 18, 1, "[Riferito all'enorme compagno di cella che dorme sopra di lui] Crapanzano, meno male che oggi esci... avrò dormito un'ora in due anni!", 2 },
                    { 19, 2, "[Restituendo alla madre il bambino che gli ha vomitato sulla giacca, affidatogli da una passante] Signora, le do un consiglio: lo faccia vedere da un esorcista.", 2 },
                    { 20, 2, "[Rivolto a Giacomo che ha lasciato la pistola nel portaoggetti] Ma chi è che ti ha addestrato a te, Topo Gigio?", 2 },
                    { 21, 2, "[Rivolto a Giacomo che ha lasciato la pistola nel portaoggetti] Ma chi è che ti ha addestrato a te, Topo Gigio?", 2 },
                    { 22, 1, "Sì, ho conosciuto una ragazza si chiama Clara, è bellissima, è bionda, è bellissima, è... vabbè, più bionda che bellissima...", 2 },
                    { 23, 1, "[Rivolgendosi a Giacomo che, in una discesa, si era dimenticato di tirare il freno a mano] Mii ma dove hai preso la patente? Alla sala giochi?", 2 },
                    { 24, 1, "[Mentre lui, Giovanni e Giacomo vengono inseguiti da un elicottero e dalle volanti della polizia] Ma che cosa vogliono fare?! Che cosa credono di fare?!? Cos'è, Apocalypse Now?!?", 2 },
                    { 25, 1, "Che cos'è il rancore? Il rancore è quella cosa... Che quando... Lo so, ti si... Eh la... Cioè il rancore, lo dice la parola stessa: ran-core, che la... Bisogna... Maria, ma proprio io dovevo fare la voce fuori campo!", 4 },
                    { 26, 1, "Maria, che dolore! Ma porca miseria! Miliardi di piastrine perse per sempre!! [vedendo il sangue uscirgli dal naso dopo aver preso una testata da Dalia]", 4 },
                    { 27, 1, "Le mutande! Quando le cerchi non si trovano mai!", 4 },
                    { 28, 1, "Se non mi licenziano loro, mi licenzio da solo, perché li capisco.", 4 },
                    { 29, 1, "Lo so, visti così sembravamo tre coglioni... e forse lo eravamo. [raccontando della situazione lavorativa di lui, Giovanni e Giacomo]", 4 },
                    { 30, 1, "Insomma credevamo che fosse uno di quei giorni in cui tutto sta per iniziare, invece era solo l'inizio della fine!", 4 },
                    { 31, 2, "Chiedimi se sono felice!", 4 },
                    { 64, 1, "Noi siamo una squadra. Ma che dico una squadra... Noi siamo la squadra per antonomasia! I Charlatans!", 9 },
                    { 65, 1, "Un'altra emergenza... Il pitone dei Galbiati si è mangiato il gatto... gli avevo detto di non farli giocare assieme...", 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_ActorId",
                table: "Quotes",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_MovieId",
                table: "Quotes",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}

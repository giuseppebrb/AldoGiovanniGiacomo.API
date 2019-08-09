using AldoGiovanniGiacomo.API.DTOs;
using Microsoft.EntityFrameworkCore;
using System;

namespace AldoGiovanniGiacomo.API.Contexts
{
    public class AldoGiovanniGiacomoAPIContext : DbContext
    {
        public AldoGiovanniGiacomoAPIContext(DbContextOptions<AldoGiovanniGiacomoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ActorDTO> Actors { get; set; }
        public DbSet<MovieDTO> Movies { get; set; }
        public DbSet<QuoteDTO> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var actors = new ActorDTO[]
            {
                new ActorDTO { Id=1, Name="Aldo", Surname="Baglio", Birth=new DateTime(1958, 9, 28), BirthPlace="Palermo" },
                new ActorDTO { Id=2, Name="Giovanni", Surname="Storti", Birth=new DateTime(1957, 2, 20), BirthPlace="Milano" },
                new ActorDTO { Id=3, Name="Giacomo", Nickname="Giacomino", Surname="Poretti", Birth=new DateTime(1956, 4, 26), BirthPlace="Villa Cortese" },
            };

            var movies = new MovieDTO[]
            {
                new MovieDTO {Id=1, Title="Tre uomini e una gamba", Year=1997, Director="Aldo Baglio, Giovanni Storti, Giacomo Poretti, Massimo Venier" },
                new MovieDTO {Id=2, Title="Così è la vita", Year=1998, Director="Aldo Baglio, Giovanni Storti, Giacomo Poretti, Massimo Venier" },
                new MovieDTO {Id=3, Title="Tutti gli uomini del deficiente", Year=1999, Director = "Paolo Costella" },
                new MovieDTO {Id=4, Title="Chiedimi se sono felice", Year=2000, Director="Aldo Baglio, Giovanni Storti, Giacomo Poretti, Massimo Venier" },
                new MovieDTO {Id=5, Title="La leggenda di Al, John e Jack", Year=2002, Director="Aldo Baglio, Giovanni Storti, Giacomo Poretti, Massimo Venier" },
                new MovieDTO {Id=6, Title="Tu la conosci Claudia?", Year=2004, Director="Massimo Venier" },
                new MovieDTO {Id=7, Title="Anplagghed al cinema", Year=2006, Director="Arturo Brachetti, Rinaldo Gaspari" },
                new MovieDTO {Id=8, Title="Il cosmo sul comò", Year=2008, Director="Marcello Cesena" },
                new MovieDTO {Id=9, Title="La banda dei Babbi Natale", Year=2010, Director="Paolo Genovese" },
                new MovieDTO {Id=10, Title="Ammutta mudica al cinema", Year=2013, Director="Arturo Brachetti" },
                new MovieDTO {Id=11, Title="Il ricco, il povero e il maggiordomo", Year=2014, Director="Aldo Baglio, Giovanni Storti, Giacomo Poretti, Morgan Bertacca" },
                new MovieDTO {Id=12, Title="Fuga da Reuma Park", Year=2016, Director="Aldo Baglio, Giovanni Storti, Giacomo Poretti, Morgan Bertacca" }
            };

            var quotes = new QuoteDTO[]
            {
                // Tre uomini e una gamba
                new QuoteDTO { Id = 1, ActorId=1, MovieId=1, Content="[Leggendo le istruzioni di montaggio del fucile, allontana Jack] Tenere lontano dalla portata dei bambini..." },
                new QuoteDTO { Id = 2, ActorId=2, MovieId=1, Content="[Dopo che Chiara propone di fare un bagno in un lago] No eh, ragazzi, simpatia, va bene, si scherza, si gioca, gli ho fatto anche guidare la macchina, però siamo già in ritardo! Non scherziamo... [si gira e non vede più nessuno in macchina] Va bene. Ma solo cinque minuti!" },
                new QuoteDTO { Id = 3, ActorId=2, MovieId=1, Content="Ma hai visto quel cane lì? Gli hanno montato... le tibie al contrario? [riferito al bulldog Ringhio]" },
                new QuoteDTO { Id = 4, ActorId=2, MovieId=1, Content="[Dando istruzioni ad Aldo su come sistemare il pacco nel bagagliaio] Dai, mettila bene... Mettila più dritta! Mettilo fino in fondo... Sdraiato però, mettilo piatto! Piatto! Metti che succede qualcosa, mettilo piatto!" },
                new QuoteDTO { Id = 5, ActorId=2, MovieId=1, Content="Un latte macchiato tiepido, senza schiuma e con poco caffè... tiepido, eh, non freddo! Poi gli chiedi le cose... [al bar, poco dopo gli viene servito il latte] Freddo, lo sapevo io!" },
                new QuoteDTO { Id = 7, ActorId=2, MovieId=1, Content="Mattone polacco minimalista di scrittore morto suicida giovanissimo! Copie vendute: due. [parlando del libro che sta comprando Giacomo]" },
                new QuoteDTO { Id = 8, ActorId=2, MovieId=1, Content="Ma vai! Ma vieni! Ma chi sono? Eh, pirletti, dimmi, chi sono? Altro che la tua ruota! [vede il padre dei bambini che lo guarda storto] Chi arriva ultimo [all'auto] è pirla!" },
                new QuoteDTO { Id = 9, ActorId=2, MovieId=1, Content="Anche il capitano del Titanic lo diceva: 'Ma no, ma no, è solo un rumorino! Da niente!' [riferito ad un rumore proveniente dalla macchina]"},
                new QuoteDTO { Id = 10, ActorId=2, MovieId=1, Content="Sì, ma a te bisogna portarti in giro legato... [riferito a Aldo che fa cadere per la seconda volta i barattoli davanti all'officina del meccanico]"},
                new QuoteDTO { Id = 11, ActorId=1, MovieId=1, Content="A volte dorme di più lo sveglio che il dormiente!"},
                new QuoteDTO { Id = 12, ActorId=1, MovieId=1, Content="Una rondine non vola solo e sempre a primavera."},
                new QuoteDTO { Id = 13, ActorId=2, MovieId=1, Content="Ma vieni! Jair! È il ritorno della Grande Inter! È il ritorno! [dopo aver segnato un bel gol in 'Italia-Marocco']"},
                new QuoteDTO { Id = 14, ActorId=2, MovieId=1, Content="Questo qui [Giacomo] si deve sposare e siamo in ritardo di una vita... il dietro della macchina... completamente sfasciato... ci ha affidato un bulldog e gli [al suocero] riportiamo... un toporagno... e una gamba da trecento milioni è in mano a una banda di muratori marocchini! Ditemi voi... "},
                new QuoteDTO { Id = 15, ActorId=1, MovieId=1, Content="[Al telefono, chiama il suocero] Pronto, pronto sì, ssss sì ssì sssss stiamo, siam... sìsìsì no, è... la la lascia lasciami... è m mma maria nnn... noo... ss, bè, ss se fosse stato per me... sì... ma io ss sono il primo che che... non ho ca, non ho ca, non ho c... non ho c... [urlando stressato] Allora, mi lasci parlare o no?! Hai capito?! E non ne posso più di ascoltarti, stai parlando solo tu! E mi hai proprio rotto i coglioni, mi hai rotto i coglioni, hai capito?! Perché non sono un automa, sono una persona, e a un certo punto te lo devo proprio dire: vaffanculo! Vaffanculo!! V, A, F, F, 'ncuuuulo!!! Tu, il tuo negozio, la tua villa di merda, mi fai schifo, strooonzoo!! [chiude furiosamente la chiamata e gli altri lo guardano colpiti] Era occupato."},
                new QuoteDTO { Id = 16, ActorId=1, MovieId=1, Content="Giacomino è in bagno... Giacomino sta dormendo... eh sì... sta dormendo in bagno... eh, si vede che si è addormentato mentre stava cagando! Che ne so io! Stiamo arrivando! Sì! Ma stiamo arriva... ma... [Aldo da un'occhiata crudele al cellulare mentre Giuliana ancora blatera] Ma vaffancuuulo! [Aldo getta furiosamente il cellulare in mare dopo essere stato stressato da Giuliana, e Giovanni e Giacomo lo guardano colpiti]"},

                // Così è la vita
                new QuoteDTO { Id = 17, ActorId=2, MovieId=2, Content="[Dopo avergli sparato un proiettile in una gamba] Ma non fare polemiche, Jack, ha rimbalzato!"},
                new QuoteDTO { Id = 18, ActorId=1, MovieId=2, Content="[Riferito all'enorme compagno di cella che dorme sopra di lui] Crapanzano, meno male che oggi esci... avrò dormito un'ora in due anni!"},
                new QuoteDTO { Id = 19, ActorId=2, MovieId=2, Content="[Restituendo alla madre il bambino che gli ha vomitato sulla giacca, affidatogli da una passante] Signora, le do un consiglio: lo faccia vedere da un esorcista."},
                new QuoteDTO { Id = 20, ActorId=2, MovieId=2, Content="[Rivolto a Giacomo che ha lasciato la pistola nel portaoggetti] Ma chi è che ti ha addestrato a te, Topo Gigio?"},
                new QuoteDTO { Id = 21, ActorId=2, MovieId=2, Content="[Rivolto a Giacomo che ha lasciato la pistola nel portaoggetti] Ma chi è che ti ha addestrato a te, Topo Gigio?"},
                new QuoteDTO { Id = 22, ActorId=1, MovieId=2, Content="Sì, ho conosciuto una ragazza si chiama Clara, è bellissima, è bionda, è bellissima, è... vabbè, più bionda che bellissima..."},
                new QuoteDTO { Id = 23, ActorId=1, MovieId=2, Content="[Rivolgendosi a Giacomo che, in una discesa, si era dimenticato di tirare il freno a mano] Mii ma dove hai preso la patente? Alla sala giochi?"},
                new QuoteDTO { Id = 24, ActorId=1, MovieId=2, Content="[Mentre lui, Giovanni e Giacomo vengono inseguiti da un elicottero e dalle volanti della polizia] Ma che cosa vogliono fare?! Che cosa credono di fare?!? Cos'è, Apocalypse Now?!?"},

                // Tutti gli uomini del deficiente

                // Chiedimi se sono felice
                new QuoteDTO { Id = 25, ActorId=1, MovieId=4, Content="Che cos'è il rancore? Il rancore è quella cosa... Che quando... Lo so, ti si... Eh la... Cioè il rancore, lo dice la parola stessa: ran-core, che la... Bisogna... Maria, ma proprio io dovevo fare la voce fuori campo!"},
                new QuoteDTO { Id = 26, ActorId=1, MovieId=4, Content="Maria, che dolore! Ma porca miseria! Miliardi di piastrine perse per sempre!! [vedendo il sangue uscirgli dal naso dopo aver preso una testata da Dalia]"},
                new QuoteDTO { Id = 27, ActorId=1, MovieId=4, Content="Le mutande! Quando le cerchi non si trovano mai!"},
                new QuoteDTO { Id = 28, ActorId=1, MovieId=4, Content="Se non mi licenziano loro, mi licenzio da solo, perché li capisco."},
                new QuoteDTO { Id = 29, ActorId=1, MovieId=4, Content="Lo so, visti così sembravamo tre coglioni... e forse lo eravamo. [raccontando della situazione lavorativa di lui, Giovanni e Giacomo]"},
                new QuoteDTO { Id = 30, ActorId=1, MovieId=4, Content="Insomma credevamo che fosse uno di quei giorni in cui tutto sta per iniziare, invece era solo l'inizio della fine!"},
                new QuoteDTO { Id = 31, ActorId=2, MovieId=4, Content="Chiedimi se sono felice!"},
                new QuoteDTO { Id = 32, ActorId=2, MovieId=4, Content="Ma cosa c'hai nel cervello? Le scimmie urlatrici?"},
                new QuoteDTO { Id = 33, ActorId=2, MovieId=4, Content="Anche mia nonna quando doveva mettermi le supposte da bambino me le spalmava sul sellino della bicicletta!"},
                new QuoteDTO { Id = 34, ActorId=1, MovieId=4, Content="Perché l'amore, quando ci si mette, è veramente bastardo."},
                new QuoteDTO { Id = 35, ActorId=1, MovieId=4, Content="Giacomino, ti prego, scarricamela!"},
                new QuoteDTO { Id = 36, ActorId=2, MovieId=4, Content="Giacomo, guarda, parlare con te o parlare con Biscardi è la stessa cosa..."},
                new QuoteDTO { Id = 37, ActorId=1, MovieId=4, Content="Ma possibile che come ti muovi pesti una merda? In un colpo solo gli hai fatto fuori il lavoro e la fidanzata! Adesso prendi una macchina, gli metti sotto la madre e finisci il lavoro. E comunque Giacomino se ti chiedo un favore, domani, non farmelo!"},
                new QuoteDTO { Id = 38, ActorId=2, MovieId=4, Content="Aldo, non è che perché hai un frigo degli anni '60 ci devi tener dentro la roba degli anni '60!"},
                new QuoteDTO { Id = 39, ActorId=2, MovieId=4, Content="Ma che cosa cazzo me ne frega di cosa avete bevuto?? Piuttosto dimmi cosa ti ha detto! [Aldo accende lo stereo] Ma la vuoi spegnere quella merda di musica o no??"},
                new QuoteDTO { Id = 40, ActorId=1, MovieId=4, Content="Per favore, lascia stare... Giacomino, vattene, lasciami solo. [dopo la furibonda rabbia di Giovanni che ha distrutto tutta la scenografia]"},
                new QuoteDTO { Id = 41, ActorId=1, MovieId=4, Content="Avete presente la teoria del piano inclinato? No? Ve la spiego. Se mettete una pallina su un piano inclinato la pallina comincia a scendere, e per quanto impercettibile sia l'inclinazione, inizia a correre e correre sempre più veloce. Fermarla, è impossibile. Ma per fortuna gli uomini non sono palline: basta un gesto, un'occhiata, una frase qualsiasi a fermare il corso delle cose."},

                // La leggenda di Al, John e Jack
                new QuoteDTO { Id = 42, ActorId=1, MovieId=5, Content="E voi chi minchia siete?"},
                new QuoteDTO { Id = 43, ActorId=2, MovieId=5, Content="Tanti auguri a Jack | Tanti auguri a Jack | Tanti auguri impasticcomane! | Tanti auguri a te!"},
                new QuoteDTO { Id = 44, ActorId=3, MovieId=5, Content="Anzi fai una cosa, Johnny: ammazzalo così la smette di soffrire, va! [riferito ad Al che ha perso la memoria]"},
                new QuoteDTO { Id = 45, ActorId=3, MovieId=5, Content="Johnny, Johnny, non piangere, che diventi brutto!"},
                new QuoteDTO { Id = 46, ActorId=2, MovieId=5, Content="Le ha spente con la tosse... [le candeline] [riferito a Jack e alla sua salute 'non proprio di ferro']"},
                new QuoteDTO { Id = 47, ActorId=3, MovieId=5, Content="Ma quant'è bella la mafia!"},
                new QuoteDTO { Id = 48, ActorId=2, MovieId=5, Content="Buongiorno signora e benvenuta. È un piacere accoglierLa in questa città di New York, città bellissima ma non altrettanto che Lei. [John, che si studia il benvenuto da fare alla zia del boss Genovese che è in arrivo a New York]"},
                new QuoteDTO { Id = 49, ActorId=2, MovieId=5, Content="Jack, noi stiamo mettendo la nostra vita nelle sue mani e questo non sa neanche come si chiama!  [riferito ad Al, che aveva appena detto di chiamarsi Niccolò Carosio]"},
                new QuoteDTO { Id = 50, ActorId=3, MovieId=5, Content="Johnny, a te te lo devono dare il premio Nobel per la mafia, e se non te lo danno è perché è tutto un magna magna."},
                new QuoteDTO { Id = 51, ActorId=2, MovieId=5, Content="Che tocchi? Che tocchi, Jack? Non è roba per te! Non hai mai avuto manualità!"},
                new QuoteDTO { Id = 52, ActorId=1, MovieId=5, Content="E vedi di non farmi diventare Al tre dita. [riferito a Jack che attacca un quadro con la pistola]"},

                // Tu la conosci Claudia?
                new QuoteDTO { Id = 53, ActorId=1, MovieId=6, Content="Senta, io mi prendo le mie responsabilità, ma siamo sicuri che il chiosco non sia abusivo? [dopo aver investito una bancarella]"},
                new QuoteDTO { Id = 54, ActorId=1, MovieId=6, Content="Ma proprio adesso che mi stavo innamorando, che ero deciso di fare il passo più lungo della gamba! Io lo so quando è crollato tutto: è stato quel maledetto momento in cui abbiamo visto insieme il marito! [piangendo]"},
                new QuoteDTO { Id = 55, ActorId=1, MovieId=6, Content="Claudia non esiste, suo marito non esiste! Claudia non esiste, suo marito non esiste!"},
                new QuoteDTO { Id = 56, ActorId=2, MovieId=6, Content="Senti, 'NonSoloTaxi', ma come guidi? Porca puttana, va' come hai conciato la macchina... Allora, di constatazione amichevole non ne parliamo neanche, eh, tanto nessun giudice ti darebbe ragione! [dopo aver tamponato Aldo]"},
                new QuoteDTO { Id = 57, ActorId=1, MovieId=6, Content="C'è un posto dove posso vomitare un attimo? Un posto specifico per il vomito, insomma: un vomituario, anche di modeste proporzioni."},
                new QuoteDTO { Id = 58, ActorId=1, MovieId=6, Content="Se queste mura potessero parlare, si dovrebbero confessare! Fuochi! Fiamme! Sodoma! Gamarra! Eh?"},
                new QuoteDTO { Id = 59, ActorId=1, MovieId=6, Content="Miiii, che bello! Unplugged!"},
                new QuoteDTO { Id = 60, ActorId=2, MovieId=6, Content="Allora lo vogliamo far smettere di piangere 'sto bambino o no, eh? Sono le tre di notte! [più furioso di prima] Li vogliamo spendere 'sti due soldi per farlo visitare da uno specialista o no, eh? Ve ne consiglio uno: Dott. Sirchioli. 6832173! [sempre più infuriato] Cosa faccio, chiamo i carabinieri, eh??? [sentendo il bambino dei vicini che piange forte]"},

                // Anplagghed al cinema

                // Il cosmo sul comò
                new QuoteDTO { Id = 61, ActorId=2, MovieId=8, Content="[Ad Aldo, che indossa una camicia a fiori] Ma come sei vestito? Stai andando al Carnevale di Venezia? Sembri Brighella con le scarpe di Pantalone!"},
                new QuoteDTO { Id = 62, ActorId=1, MovieId=8, Content="Equilibre, equilibre, equlibre..."},
                new QuoteDTO { Id = 63, ActorId=2, MovieId=8, Content="Scivolement, scivolement, scivolement..."},

                // La banda dei Babbi Natale
                new QuoteDTO { Id = 64, ActorId=1, MovieId=9, Content="Noi siamo una squadra. Ma che dico una squadra... Noi siamo la squadra per antonomasia! I Charlatans!"},
                new QuoteDTO { Id = 65, ActorId=1, MovieId=9, Content="Un'altra emergenza... Il pitone dei Galbiati si è mangiato il gatto... gli avevo detto di non farli giocare assieme..."},

                // Ammutta muddica al cinema

                // Fuga da Reuma Park

            };

            modelBuilder.Entity<ActorDTO>().HasData(actors);
            modelBuilder.Entity<MovieDTO>().HasData(movies);
            modelBuilder.Entity<QuoteDTO>().HasData(quotes);

            base.OnModelCreating(modelBuilder);
        }
    }
}

using AldoGiovanniGiacomo.API.Contexts;
using AldoGiovanniGiacomo.API.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AldoGiovanniGiacomo.API_Test
{
    public class Initialize
    {
        public static AldoGiovanniGiacomoAPIContext CreateNewTestContext()
        {
            var optionBuilder = new DbContextOptionsBuilder<AldoGiovanniGiacomoAPIContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());

            return new AldoGiovanniGiacomoAPIContext(optionBuilder.Options);
        }

        public static void SeedTestDb(AldoGiovanniGiacomoAPIContext context)
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
                new QuoteDTO { Id = 1, ActorId=1, MovieId=5, Content="E voi chi minchia siete?", Movie=movies[4], Actor=actors[0] },
                new QuoteDTO { Id = 2, ActorId=2, MovieId=5, Content="Tanti auguri a Jack | Tanti auguri a Jack | Tanti auguri impasticcomane! | Tanti auguri a te!", Movie=movies[4], Actor=actors[1] },
                new QuoteDTO { Id = 3, ActorId=3, MovieId=5, Content="Anzi fai una cosa, Johnny: ammazzalo così la smette di soffrire, va! [riferito ad Al che ha perso la memoria]", Movie = movies[4], Actor = actors[2] },
                new QuoteDTO { Id = 4, ActorId=3, MovieId=5, Content="Johnny, Johnny, non piangere, che diventi brutto!", Movie = movies[4], Actor = actors[2]},
                new QuoteDTO { Id = 5, ActorId=2, MovieId=5, Content="Le ha spente con la tosse... [le candeline] [riferito a Jack e alla sua salute 'non proprio di ferro']", Movie = movies[4], Actor = actors[1]},
                new QuoteDTO { Id = 6, ActorId=3, MovieId=5, Content="Ma quant'è bella la mafia!", Movie = movies[4], Actor = actors[2]},
                new QuoteDTO { Id = 7, ActorId=2, MovieId=5, Content="Buongiorno signora e benvenuta. È un piacere accoglierLa in questa città di New York, città bellissima ma non altrettanto che Lei. [John, che si studia il benvenuto da fare alla zia del boss Genovese che è in arrivo a New York]", Movie = movies[4], Actor = actors[1]},
                new QuoteDTO { Id = 8, ActorId=2, MovieId=5, Content="Jack, noi stiamo mettendo la nostra vita nelle sue mani e questo non sa neanche come si chiama!  [riferito ad Al, che aveva appena detto di chiamarsi Niccolò Carosio]", Movie = movies[4], Actor = actors[1]},
                new QuoteDTO { Id = 9, ActorId=3, MovieId=5, Content="Johnny, a te te lo devono dare il premio Nobel per la mafia, e se non te lo danno è perché è tutto un magna magna.", Movie = movies[4], Actor = actors[2]},
                new QuoteDTO { Id = 10, ActorId=2, MovieId=5, Content="Che tocchi? Che tocchi, Jack? Non è roba per te! Non hai mai avuto manualità!", Movie = movies[4], Actor = actors[1]},
                new QuoteDTO { Id = 11, ActorId=1, MovieId=5, Content="E vedi di non farmi diventare Al tre dita. [riferito a Jack che attacca un quadro con la pistola]", Movie = movies[4], Actor = actors[0]}
            };

            var dialogues = new DialogueDTO[]
            {
                // La leggenda di Al, John e Jack
                new DialogueDTO { Id = 1, MovieId=5, Content="John: Che stai facendo, Jack? Che stai facendo?\nJack: Johnny... Smarties contro Anfetamine, no? [si vedono appunto degli Smarties e delle pasticche di anfetamine disposti su una scacchiera]\nJohn: E ti sembra il momento?\nJack: È sempre il momento!\nJohn [esegue alcune mosse per far concludere la partita]: Partita finita." },
                new DialogueDTO { Id = 2, MovieId=5, Content="Al [vedendo ridere John e Jack]: Che c'è da ridere?\nJohn: Niente, Al...\nAl: E fate ridere un po' anche me!\nJohn: No, è che... tuo fratello, no?\nAl: Che c'hai da dire su mio fratello, parla.\nJohn: Niente, così, dico che... A conoscerlo superficialmente... Tuo fratello è un po'... Eh? [si scambia uno sguardo d'intesa con Jack e ride]\nAl: È un po' cosa? Parla!\nJohn: Niente, dai, lasciamo perdere, non parliamone più.\nAl: No, parliamone, parliamone, stiamo parlando di mio fratello e parliamone, giusto?\nJack: Allora Al, ti sta dicendo che... Tuo fratello... Ti sta dicendo che tuo fratello... è un ricchione!\nAl: Mio fratello non è un ricchione! È raffinato!\nJack: Cos'è tuo fratello?\nAl: Raffinato! E comunque stiamo facendo un lavoro, facciamolo e basta, va bene? C'è da ammazzare qualcuno? Ammazziamolo e basta!\nJack: Mii, che clima... E come si fa ad ammazzare la gente con questo clima? Che siamo, delle macchine?" },
                new DialogueDTO { Id = 3, MovieId=5, Content="Al: Johnny, vai dritto verso la discarica.\nFrankie: No, la discarica no! Lo so che cosa succede alla discarica!\nJohn: E che cosa succede alla discarica, Frankie? Che si butta la spazzatura!" },
                new DialogueDTO { Id = 4, MovieId=5, Content="John: E vabbè va', oggi mi sento di buon umore. Frankie, se risponderai a una domandina facile facile, te ne torni a casa dai tuoi bambini, eh?\nFrankie: Grazie Johnny, ti dico tutto quello che vuoi sapere.\nJohn: Ecco, allora dimmi: qual è la capitale della Birmania?\nFrankie [stupito]: Ma... come... la...\nJohn: La capitale della Birmania, Frankie!\nFrankie: Ragazzi, ma perché fate così, come faccio a sapere la capitale della Birmania?\nJohn: Ahi, ahi, ahi, che peccato, che peccato, che peccato, Frankie! Tra l'altro potevi dire una cosa qualsiasi che a noi andava bene! Chi minchia la sa la capitale della Birmania, Frankie?!" },
                new DialogueDTO { Id = 5, MovieId=5, Content="Al: ...Ooh, non sai quale cosa si può fare, Johnny...? ...Non lo possiamo mandare a casa? [Frankie Culo di gomma]\nJohn: Le regole sono regole, Al.\nJack: E c'ha ragione, Johnny, che mondo sarebbe senza le regole, eh?\nJohnny: Poi anche volendo, come facciamo col boss? Quello vuole il suo cuore su un piatto d'argento.\nAl: E che problema c'è? Ammazziamo un cerbiatto e gli portiamo il suo cuore al boss. ...non avete visto Biancaneve e i sette nani?" },
                new DialogueDTO { Id = 6, MovieId=5, Content="[Dopo aver ucciso il presunto Frankie Culo di gomma]\nJohn: Scusa Al, ma... non avevi detto che volevi salvargli la vita?\nAl: Sì, Johnny... E dove minchia lo troviamo un cerbiatto a New York?" },
                new DialogueDTO { Id = 7, MovieId=5, Content="John: Allora, vediamo domani. Ore 4: far saltare la tintoria dei Jefferson. E mi raccomando Jack, non come l'altra volta che ti sei dimenticato il numero e hai fatto saltare un negozio a caso!\nJack: Sì, però poi era quello giusto!\nJohn: Quella è fortuna, non si lavora così, siamo professionisti!" },
                new DialogueDTO { Id = 8, MovieId=5, Content="Al: Ti sento, Diavolo, che sei in questa casa! Entra in me! Entra in me, Diavolo! Satana di un satanasso! Io ti scaccio-da questa-casa-male-detta!! Io ti posso affrontare! Hai capito?! Vai via, Satana!!\nJohn: Che minchia sta succedendo, Jack?\nJack: Minchia, Johnny, mi sto ammazzando dalle risate!\nAl: Rientra nelle tenebre! Entra in me! Entra in me!\nJohn: Ma che gli hai fatto, Jack?\nJack: Ma niente, Johnny, si è addormentato, poi quando s'è svegliato gli ho fatto credere di essere un esorcista! Ah ah ah!\nAl: So che sei qua!! Non mi fai paura!! Abbandona!! Rientra!!! Nelle!!! Tenebre!!!\nJohn: Ma sei impazzito??\nJack: Mi sto ammazzando dalle risate, Johnny! Che bella vita che facciamo, Johnny! Guarda che ridere fa bene! E poi, oh, il bello deve ancora avvenire, eheheheh! [silenzio. Al guarda John in modo strano credendo che fosse il Diavolo]\nJack [sottovoce a John]: E credici un pochino...\nAl: Diavolo, ti ho trovato finalmente. Esci da questo corpo deforme. Entra in me. Cosa sei...? Entra in me! Abbandona questo grottesco involucro ed entra in me! Entra in me, adesso...! [John lo colpisce sul naso con il calcio della pistola e lo fa cadere per terra privo di sensi]\nJohn: Come faccio con te, Jack? Come faccio?\nJack: E che ne so, Johnny...\nJohn: Due ore di lavoro buttate via! Quante volte te l'ho detto? Non è un giocattolo, non è un giocattolo!\nJack: Ma mi annoio, Johnny!\nJohn: Jack! Jack! Jack!\nJack: Comunque faceva ridere, di' la verità!" },
                new DialogueDTO { Id = 9, MovieId=5, Content="Jack: Ma come facevi a sapere che mi piaceva proprio la pistola? \nAl: Eh, tu tre gusti hai! La pistola, le anfetamine e la torta di Melissa." },
                new DialogueDTO { Id = 10, MovieId=5, Content="John: Jack, quante volte te lo devo dire, non si spara ai cani! \nJack: E perché? \nJohn: Perché sono animali superiori! \nJack: E chi l'ha detto? \nJohn: Ma la scienza lo dice, Jack, la scienza! \nJack: La scienza? \nJohn: Ma che ne sai tu di scienza!" },
                new DialogueDTO { Id = 11, MovieId=5, Content="John: [Jack spara alcuni colpi in aria per la casa] Ma che fai, Jack? Che fai? \nJack: Johnny, ho guardato il libro di Carabbaggio? E lasciami provare 'sta pistola! [Continua a sparare e cade un quadro] \nJohn: Minchia, quante volte ti ho detto che non si spara in casa, Jack? Quante? \nJack: Cinque? \nJohn: No, sette! \nJack: Minchia, non mi sta in testa..." },
            };

            context.AddRange(actors);
            context.AddRange(movies);
            context.AddRange(quotes);
            context.AddRange(dialogues);
            context.SaveChanges();
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AldoGiovanniGiacomo.API.Migrations
{
    public partial class DTOsRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: @"Giacomo [al telefono con Giovanni]: Pronto? 
Giovanni: Giacomo, tutto a posto? 
Giacomo: Sì, è tutto a posto... senti, mi chiami dopo che mi sta finendo il film? 
Giovanni: No, stiamo chiudendo, dai! A proposito, dove hai messo le rondelle del sei, che Aldo non le trova? 
Giacomo: Cosa ne so io delle rondelle del sei, dai, chiamami dopo, dai! 
Giovanni: Senti, le commissioni le hai fatte? 
Giacomo: Le ho fatte tutte, sì. 
Giovanni: Il vestito l'hai ritirato?
Giacomo: Eh, secondo te mi sposo nudo?
Giovanni: Eh... gli anelli?
Giacomo: Ma che palle che sei! Certo che li ho ritirati gli anelli!
Giovanni: Anche le scarpe?
Giacomo: Le scarpe le ho ri... Porca puttana, le scarpe!
Giovanni: Hai visto? Se non ti telefonavo io ti sposavi in ciabatte! 
Giacomo: Vabbe' dai, se mi sbrigo riesco a andare a ritirarle, dai! 
Giovanni: Ah, a proposito, il pacco è arrivato, eh... domattina andiamo a ritirarlo prima di partire. Senti, ti vengo a prendere verso le... sette e mezza. 
Giacomo: Ma come le sette e mezza? 
Giovanni: Vabbe'... sette e un quarto. Ciao!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: @"Giacomo [verso la casa di Aldo]: Aldo! Aldo! 
Giovanni e Giacomo [urlando]: Aldo!! 
Giovanni: Aldo! 
Giacomo [urlando]: Aldooo!! 
Giovanni: Allora?!? 
Giacomo [urlando di più]: Aldoooo!!! 
Aldo [nella finestra]: Allora, che c'è!? 
Giovanni: E che ha detto alle otto, sono le otto e sette! 
Aldo: E c'è bisogno di gridare così?! Qui c'è gente che mi conosce! 
Giacomo: Dai, su, sbrigati, scendi, che dobbiamo anche ritirare il pacco, dai! 
Aldo: Va be', finisco di mangiare la peperonata e scendo! 
Giovanni [a Giacomo]: Peperonata? Alle otto del mattino? Mezzogiorno... topi morti?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: @"Portinaia: Signor Giovanni! Signor Giovanni! Buongiorno signor Giovanni... come sta la sua signora? È già giù al mare che l'aspetta, nè? Ma lei non è geloso? 
Giovanni: Be'... 
Portinaia: Eh, me la saluti tanto, tanto... e lei, signor Giacomo! Il grande giorno si avvicina, eh? Paura? 
Giacomo: Mah, insomma, ancora tre giorni e poi mi sposo... 
Portinaia: Eh, era ora che facesse qualcosa anche lei, eh! Così siete a posto tutti e tre, finalmente! A proposito, se non togliete la macchina lì davanti al portone immediatamente, io ve la faccio rigare da mio marito! E poi ve la faccio anche portar via dai vigili! Capito? Eheheh! [a Giovanni] Buon viaggio, nè! [a Giacomo] Buon viaggio anche a lei, nè!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: @"[Aldo ruba il posto in macchina a Giacomo proprio quando si sta sedendo]
Aldo: Scusa! 
Giacomo: Ma come 'scusa'? Arrivi, neanche saluti e mi ciuli il posto?
Aldo: Hai ragione. Ciao, come stai? Andiamo Giovanni, che è tardi!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: @"Donna: Ma chi sono quelli là? 
Portinaia: Ma come chi sono? Quelli là son dei mantenuti! 
Donna: Ma chi? 
Portinaia: Due hanno sposato le sorelle Cecconi, e l'altro sta per attaccare il cappello con la più giovane, la terza! 
Donna: Mmmh!... 
Portinaia: E adesso stanno andando giù nel meridione, nelle Puglie, per fare il matrimonio, perché il cavalier Cecconi vuole celebrarlo giù a Gallipoli dov'è nata sua moglie! 
Donna: Ma, scusi, le figlie del dottor Cecconi...? 
Portinaia: Certo! Sì, quello che ha quella grande catena di negozi di ferramenta, che se non fosse per lui, ti dico la verità, io ti assicuro che quei tre lì a quest'ora sarebbero in mezzo alla strada!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: @"[In macchina] 
Giovanni: Scusa, puoi togliere i piedi dal cruscotto, che lo sporchi?
Aldo: Mi', come sei pignolo! 
Giovanni: Io sono pignolo? 
Giacomo: Be', un po' pignolo lo sei! 
Giovanni: Cioè, questo qua mi cammina sul cruscotto ed io sarei pignolo! 
Giacomo: Capito, ma devi anche saperle accettare le critiche, sennò... 
Giovanni: Va be', allora, visto che sono pignolo: puoi spostare la gambetta sennò non entran le marce? 
Aldo: Lo vedi che sei veramente pignolo? 
Giovanni: Ecco, allora facciamo tutto il viaggio in prima perché sennò io sarei pignolo! Comunque mettiti le cinture, che se facciamo un incidente e sbatti l'assicurazione non paga. 
Aldo: Ma a che serve? Stiamo andando a trenta all'ora! 
[Giovanni frena di colpo e Aldo sbatte la testa sul cruscotto] 
Giovanni: Visto? 
Giacomo: Allora sei bastardo! 
Giovanni: E pignolo!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 7,
                column: "Content",
                value: @"Giovanni: Allora io vado a prendere il pacco, tu... non so... vai a prendere...
Giacomo: Scusa, ma possibile che quando c'è un lavoro di responsabilità devi farlo sempre tu? Cos'è, io non son capace?
Giovanni: No. Però, se vuoi andare...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 8,
                column: "Content",
                value: @"Giovanni [parlando della scultura]: Cos'è 'sta roba? Scusate ma... centosettanta milioni per questa merdina qua? Ma dai, è una follia!
Giacomo: Ma che follia, che follia!? Ma lo sai che questo qui è un Garpez, uno dei più grandi scultori viventi?
Giovanni: Ma scultore che cosa? Ma guarda che il mio falegname con trentamila lire la fa meglio, va', non ha neanche le unghie!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 9,
                column: "Content",
                value: @"Cecconi: Lo sai come so' fatti 'sti artisti... Mezzi drogati, mezzi froci... ma comunque, se 'more, la gamba fa un sarto [salto], uno zompo, e va a trecento milioni! Ma che sto a di', a te, che nun capisci niente, su! Per piacere, a' nano [sarebbe Giacomo], e passame er pignolo [sarebbe Giovanni], và! Pronto, pignolo? Andò state?
Giovanni: Eh, è poco che siam partiti, avremo fatto... quaranta chilometri!
Cecconi: Aoh, 'a pigno', ma dovete sbrigarve, dovete còre! [correre] Perché stasera c'abbiamo una cena! Sì, siete tutti invitati ar Gambrinuse, ar ristorante! Così ve presento er prete. Oh, me raccomando, eh... nun me fate fa' figure de merda! Mi raccomando! [il cane Ringhio abbaia] Oh... oh, oh, sento Ringhio! Ah, ah, Ringhio, a papà, fa sentì 'a vocetta tua! [il cane Ringhio abbaia forte] Eheheh, meno male che ce sei te, Ringhio... eh, sei l'unico che me dà soddisfazione...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 10,
                column: "Content",
                value: @"Giacomo: Scusa, puoi tirar su il finestrino? Lo sai che ho avuto problemi al trigemino quest'anno. [Giovanni chiude il finestrino ed accende l'aria condizionata] Ti dico di tirar su il finestrino, mi accendi l'aria condizionata? Ho già fatto tre bronchiti quest'anno! 
Giovanni: Ho capito, se fumi attacco l'aria condizionata, cosa faccio, accendo la radio? 
Giacomo: No, la radio no perché ho già un po' di mal di testa. 
Giovanni: Sì, ma se lo dicevi prima ci portavamo dietro il polmone d'acciaio! Eh cazzo!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 11,
                column: "Content",
                value: @"Aldo: Oh! Ti fermi che devo fare pipì? 
Giovanni: Eh, adesso mi fermo ogni due minuti perché devi far pipì? 
Aldo: Va bene, allora ti piscio in macchina!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 12,
                column: "Content",
                value: @"Giovanni: Senti, lega il mostro [il cane Ringhio] alla macchina, così ci fa anche la guardia. 
Aldo: Ma perché, non può venire? 
Giovanni: Chi, la merdina? 
Aldo: Dammi qua, per l'amore della pace, va!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 13,
                column: "Content",
                value: @"Aldo: Ma quanti libri legge quello lì [Giacomo]? 
Giovanni: Ma neanche uno! Ne compra cento al mese e non gliene ho visto sfogliare uno!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 14,
                column: "Content",
                value: @"Giovanni [Dopo che lui e Giacomo hanno visto che il cane Ringhio non c'è più]: Be', così è la vita...
Aldo [piangendo arrabbiato]: Con te non ci parlo più, sei un assassino!
Giovanni: Io?!? A parte che sei stato tu a legarlo [Ringhio] dietro!
Aldo: Sì ma sei tu il piede che gli ha dato la morte!
Giacomo: Dai, quel che è stato è stato, è inutile star qui a litigare per questo!
Giovanni: ""Quel che è stato è stato"" un paio di balle! Chi è che glielo dice adesso al vecchio? [Cecconi]
Aldo: Quello prima ci apre la testa e poi ci sputa dentro!
Giovanni: E poi ci licenzia!
Giacomo: Certo che voi due siete proprio dei conigli, dai! Ma che paura dovete avere? Siamo delle persone civili o no? Lo si chiama e gli si spiega che è stato un incidente!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 15,
                column: "Content",
                value: @"Giacomo: Non sento nessun rumorino, a parte che ho appena avuto l'otite e non ci sento molto bene!
Giovanni: Allora sei 'na discarica!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 16,
                column: "Content",
                value: @"Giacomo [parlando di Chiara]: Oh, però è carina, eh? 
Giovanni: Carina è carina, sì. 
Giacomo: Ma non è solo carina, c'ha anche quell'aria lì un po' particolare, un po', eh...? 
Giovanni: Sì, c'ha quella roba lì, però calcola che tra due giorni ti sposi, eh! 
Giacomo: Perché, cosa ho detto di male? 
Giovanni: Be', sei sempre lì a far lo scemetto, gli occhi dolci, tì-tì-tì-tì... 
Giacomo: Che occhi dolci, ma cosa stai dicendo?! Ma Aldo, sto facendo lo scemo? 
Aldo: Be', un po' lo scemo lo stai facendo, va! 
Giovanni: Cioè, abbiam fatto la constatazione amichevole [Chiara ha tamponato l'auto del trio] e a momenti avevo torto io! 
Aldo: Be', insomma, tutte le ragioni non ce le avevi!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 17,
                column: "Content",
                value: @"Giacomo [a Chiara]: Tutto a posto? 
Chiara: Sì, per fortuna sono riuscita a spostare il traghetto, altrimenti addio vacanze! 
Giacomo: Traghetto per...? 
Chiara: Ah, Grecia. Faccio Brindisi-Patrasso, poi un giro per le isole... 
Giacomo: Vai a raggiungere... il fidanzato? 
Chiara [imbarazzata e giù di morale]: No... 
Giovanni: Toccato un tasto dolente? [Chiara annuisce] Vi siete appena lasciati. 
Chiara: Hmmm-mm. 
Giovanni: Ti ha mollato lui! 
Chiara [sull'orlo delle lacrime]: Hmmm-mm! 
Giovanni [tra sé e sé]: Si vede. 
Giacomo [tra sé e sé, rivolto a Giovanni]: Sei un deficiente! 
Giovanni: Con la tua migliore amica! [Chiara piange] 
Giacomo: Ma smettila, Giovanni! 
Giovanni: Be', lo dicevo così, per rompere il ghiaccio... 
Chiara [asciugando gli occhi]: Scusate... [al trio] Voi... siete musicisti? 
Giovanni: Come? 
Chiara: Nella custodia cosa c'è, un sax? 
Giovanni: Ah, lì... no, c'è una roba... 
Giacomo: E' un'opera d'arte, è una scultura? 
Chiara: Posso vederla? 
Giovanni: Eh no, ciccia, non è che possiamo farla vedere a chiunque! 
Giacomo: Come no, Giovanni, dai, fagliela vedere! 
Giovanni [sospirando]: Fagliela vedere... [prende la gamba e la dà a Chiara] Ecco, vedi? Guarda qua... 
Chiara: No... 
Giovanni: Eh sì, eh, purtroppo sì, eh... 
Chiara: Non è possibile, quest... è autentica? 
Giovanni: Eh, la gamba! 
Chiara: Questo è un Garpez! 
Giacomo: Ma scusa, ma come hai fatto così al volo? 
Giovanni: Per forza, è una merda, è un Garpez! Anzi, ciccia, visto che costa una cifra... [se la fa ridare] Bella, però... 
Chiara: Sì, lo so... io ho a che fare con le opere d'arte per lavoro. Sì, insomma, faccio la restauratrice. 
Giacomo: Ma va? Ma lo sai che è sempre stato il sogno della mia vita fare il re...? [Aldo e Giovanni scoppiano a ridere in crepapelle] 
Giovanni: Ma se non sai neanche unire i puntini della settimana enigmistica, Giacomo! 
Aldo: L'ho capita adesso! 
Giovanni: Ma c'è da ammazzarsi dal ridere! 
Chiara: E voi? 
Giovanni: Eh? 
Chiara: Cosa fate nella vita?
Giovanni: Be', noi... lavoriamo nella meccanica di precisione, tecnologie avanzate al servizio di progettazioni particolari e specifiche. Non so... ""harware""... 
Giacomo: Hardware! 
Giovanni: Hardware e quelle cose... cioè, creiamo dei supporti che poi serviranno per progettare grosse situazioni, non so, mecc... Proprio... Strumenti di precisione per una svolta magari futura anche della meccanica... eh, non so se mi spiego...
Aldo: Sì, insomma... Abbiamo un negozio di ferramenta... Cioè, non è che il negozio di ferramenta è nostro... noi ci lavoriamo come commessi, come galoppini, insomma, come... come... sì...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 18,
                column: "Content",
                value: @"[Nel cinema, mentre cercano il meccanico] 
Chiara: Oh! Oh! Oh! Oh! Oh! È un Garpelli! 
Giovanni: Chi? 
Chiara: È un film di Garpelli, neorealista. Non lo proiettano da trent'anni! 
Giovanni: Ci sarà il suo motivo, dai! 
Chiara: Non possiamo perderlo, vi prego! 
Giovanni: Ma no, ma... Giacomo! 
Giacomo: Eh, è un Garpelli, Giovanni! 
Giovanni: Ma dai! Aldo! 
Aldo: Vado a prendere i popcorn!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 19,
                column: "Content",
                value: @"Dottore [rivolgendosi a Giacomo]: Dunque, vediamo, nome e cognome? 
Aldo: Giacomo Poretti. 

Aldo: Ma lo conosco, è mio cognato... 
Dottore: E secondo lei io devo compilare un documento che è ufficiale mettendo le informazioni del primo che passa? [a Giacomo] Senta, è suo cognato? 
Giacomo: Si, si... 
Dottore [rivolgendosi ora ad Aldo]: Va bene, come ha detto che si chiama? 
Aldo: Perché non glielo chiede a lui? 
Giovanni: Giacomo Poretti... per favore, siamo in ritardo! [sottovoce ad Aldo] Non star lì sempre a questionare...
Dottore [scrive]: Gia-como... Po-ret-ti... Allora... vediamo un po'... se tocco qui fa male? [lo tocca, e Giacomo emette un verso di dolore] Ma è sicuro, eh? [lo tocca di nuovo, e Giacomo urla di dolore più forte] Invece se tocco qui?
Giacomo No!... 
Aldo: Dottore, perché non gli diamo un calmante per endovenosa... che ne so io, quattro cc di placibio?... 
Dottore: Ah, è medico! Non lo sapevo... È medico! E dov'è che ha studiato? Mi faccia il sacrosanto piacere di mettersi lì e di stare zitto, e non disturbi, mentre faccio il mio lavoro! Signorina, mi prepari un calmante, dunque vediamo... Quattro cc di placibio per endovena. [Aldo è visibilmente contrariato]. Ecco, la lingua, mi faccia vedere la lingua...
Aldo: Dottore, secondo me ha un colica renale. 
Dottore: Che cosa le ho detto prima? Di stare...?
Aldo: Zitto...
Dottore: E di mettersi... lì.
Aldo: Si, però, è...
Dottore: Sono io che faccio le visite. Hai capito? 
Aldo: Sì, però se tocchiamo qui [tocca Giacomo, che urla di dolore] e gli fa male non può essere una tracheite! 
Dottore: Adesso si mette anche a fare le diagnosi! È arrivato il professorone, è arrivato! Sa cosa faccio adesso? Mi tolgo il camice... mi tolgo il camice e lo do a lei, va bene? Glielo do? Vuole il camice? Stia zitto! Non voglio più sentire neanche una parola capito?! Zitto! [rivolgendosi nuovamente a Giacomo] Caro signor...
Aldo: Giacomo Poretti.
Dottore: Caro signor Poretti, qui abbiamo una bella colica renale! [Aldo fa nuovamente la faccia scocciata] Dobbiamo fare qualche esamino, lei questa notte la passa qui dentro. Motivi precauzionali. 
Giovanni: Guardi che siamo già in ritardo incredibile... 
Aldo: Non è che ti puoi mettere a discutere col professore, è un professorone! Un professorone di stirpe, non è che si è inventato, sa quello che deve dire.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 20,
                column: "Content",
                value: @"[In ospedale, Giovanni guarda fuori dalla finestra] 
Giovanni: Oh cazzo, la macchina! [Chiara] Ci ha ciulato la macchina! Ma... [rivolto a Giacomo] Hai visto? Quella tua amichetta, eh, e la Grecia, e la mitologia, e tagliamo la mela, e intanto ci ha ciulato la macchina con dentro la gamba! E io pirla, che le ho lasciato anche le chiavi! Quella grandissima... [Chiara entra nella stanza e Giovanni sorride] Chiara! 
Chiara: Voi siete matti a lasciare giù la gamba... e se ve la rubano? Ah, la... macchina l'ho messa all'ombra, era sotto il sole...
Giovanni: Brava! 
Chiara: E... questa è la tua borsa, no, Giacomo? 
Giacomo: Si... 
Chiara: Il pigiama dov'è? 
Giacomo: Eh... non c'è il pigiama. 
Chiara: Non c'è il pigiama? 
Giacomo: Eh... dormo nudo... 
Giovanni: Dormi nudo? Tu c'hai due bronchiti al giorno e dormi nudo? 
Aldo: Eeeeh, ragazzi, stiamo calmi, non è successo niente, vorrà dire che gli presterò il mio!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 21,
                column: "Content",
                value: @"[Vedendo Giacomo con indosso la maglietta che gli ha prestato Aldo]
Giovanni: Sì, però, anche tu... ti sembra il caso di dormire con la maglietta di Sforza? 
Aldo: Eh, quella di Ronaldo era finita! [Giovanni sbatte furiosamente Aldo dietro a testa la porta vetrata, che gli geme di dolore atroce]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 22,
                column: "Content",
                value: @"Giovanni: Lo sai che con venti milioni si può comprare un bar in Costa Rica? Sulla spiaggia. Sole, mare, un sacco di palme. 
Aldo: Tutto l'anno in costume.
Giovanni: Tutto l'anno in costume. Nessuno che ti rompe le palle; che ti dice quello che devi fare. Certo, ci vuole coraggio, bisogna abbandonare tutto.
Aldo: E se ti va male?
Giovanni: Be', il rischio c'è. Del resto, se non rischi. Tu hai mai rischiato?
Aldo: Una volta: una volta ho messo due fisso a Inter-Cagliari.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 23,
                column: "Content",
                value: @"Aldo: Ragazzi! Ragazzi! Ho trovato il nuovo Ringhio!
Giovanni: Ma se è nero!
Aldo: Ma perché, devi essere razzista anche coi cani?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 24,
                column: "Content",
                value: @"Chiara: E così domani ti sposi? 
Giacomo: Sì, ma niente di serio.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 25,
                column: "Content",
                value: @"Giovanni [rivolto ad Aldo che ha appena gettato la ruota di scorta nel fiume, che però non regge]: Ma sei deficiente!?
Aldo: Eh, mi credevo che galleggiava...
Giovanni: Ma se solo il cerchione pesa trenta chili!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 26,
                column: "Content",
                value: @"Jack: Se al mattino spacchi le pietre, al pomeriggio scavi le buche. Se al pomeriggio si spaccano le pietre, al mattino si scavano le buche. Se al mattino... 
Al: Se al mattino spacchi le palle, la sera pure! 
Jack: Ma che minchia di programma rieducativo è?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 27,
                column: "Content",
                value: @"Al [raccontando una barzelletta]: C'è un tipo di colore...
Jack: Che tipo di colore?
Al: Un tipo di colore!
Jack: Sì, ho capito, ma rosso, verde...
Al: Mii, un negro! Un tipo di colore negro! [...] Allora... c'è un negro che bussa alla porta di un night club...
John: Ah, ho capito... è quella che poi apre lo spioncino e lo tira fuori con le dita nel naso!
Al: Ecco, ho capito quella che dici. È bellissima! È un capolavoro della barzelletta. Ma non è quella!
Jack: Ma qual è quella che lo tira fuori con lo spioncino?
Al: Mii Jack, sto raccontando un'altra barzelletta! [...] Allora... c'è un negro che bussa alla porta di un night club...
John: Aaah... è quella che poi lui va in un altro night club!
Al: Quella!
John: Che lui corre forte...
Al: Sì, però non me la rovinare... lasciamela raccontare. 
Jack: Ma quando si ride in questa barzelletta?
John: Jack, è una barzelletta e si ride alla fine!
Al: [...] T'hanno dato trent'anni, puoi anche aspettare!
Jack: Va bene, allora... allora aspetteremo!
John: Aspetta un attimo Al, ma come mai a lui hanno dato trent'anni e a noi cinquanta?
Al: Mii Johnny, pure tu... sto raccontando una barzelletta! Mii, la sto odiando 'sta barzelletta! Allora: c'è 'sto cazzo di negro che è due ore fuori dalla porta di questo night club di mmerda! E il portiere gli risponde... 
John: Non si può entrare in questo night club. [...]
Al: E il negro gli risponde... 
John: Ma lei non sa chi sono io, mi faccia entrare!
Jack: Lei non sa chi sono io! Ma che t'inventi Johnny! 
Al: E... e il portiere gli risponde...
John: Guarda quella ragazza con la gonna rossa!
Jack: Con la gonna rossa! Miinchia! Sto scompisciando dalle risate! Haha...
Al: Ragazza... con la gonna rossa?
John: Sì...
Al: Allora non è lei...
John: Come non è? Non è che poi dice: ""Oh, c'è anche l'elefante che parla inglese...""
Jack: L'elefante che parla inglese! Johnny, sei veramente una bomba, sei! [...] Ma come finisce 'sta barzelletta?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 28,
                column: "Content",
                value: @"Giacomo: Ciao. Cosa stai leggendo oggi? 
Platone: Schopenhauer. 
Giacomo: Schopenhauer? 
Platone: Il mondo come volontà e rappresentazione. 
Giacomo: Sì, ma Platone, anche tu! Non puoi leggere Topolino come tutti gli altri bambini? Ciao Gaber! Ehi? Successo qualcosa? 
Gaber: Questa è arrivata stamattina. [Mostrando a Giacomo una lettera] Dice che dobbiamo partire entro stasera, neanche il tempo di fare le valigie ci hanno dato. 
Giacomo: Ma scusa, e per ora dove andreste? 
Gaber: Per ora da mio cugino poi boh... son disperato Giacomo. 
Giacomo: Non ti preoccupare; mi farò venire in mente qualcosa. 
Cognato di Giacomo: Ah, guarda che ber quadretto. Ammazza che schifo! Ahò, Africa! Damme un giudizio: te sembrano pulite 'ste scale? 
Gaber: Le ho appena pulite. 
Cognato di Giacomo: Va be'! Tanto tra un po' la pacchia è finita, eh? 
Giacomo: Intanto stiamo calmi, poi mi devi una spiegazione: Come mai non ne sapevo niente di 'sta roba? 
Cognato di Giacomo: Ahò! Ah Malcolm X! Intanto stai carmo te. Primo. Secondo: famo 'na bella cosa; al posto di ""unanimità"", ce scriviamo: ""Voti favorevoli: 15; voti contrari: 1"". Er tuo, eh? Giacomino, l'amico dii negri. Ciao, Congo.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 29,
                column: "Content",
                value: @"Giovanni: Io avevo un appuntamento importantissimo! 
Giacomo: Sì, dal pediatra.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 30,
                column: "Content",
                value: @"Giacomo: Anzi! Se proprio vuoi saperlo, io il poliziotto non volevo neanche farlo. È capitato. 
Giovanni: Eh, e se non capitava era meglio!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 31,
                column: "Content",
                value: @"Giacomo: Sai com'è la vita, capitano delle cose più grosse di te e devi prendere delle decisioni, un po' come il bivio di prima, ti ricordi, ""Che faccio? Vado a destra o vado a sinistra?"" E lì se non stai attento rischi di sbagliare, rischi di prendere la strada sbagliata. 
Giovanni: E tu l'hai presa in pieno, contromano!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 32,
                column: "Content",
                value: @"Giacomo: Tra l'altro ho anche finito di scrivere un romanzo. 
Giovanni [sarcastico]: Non vedo l'ora di leggerlo, c'ho l'acquolina in bocca.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 33,
                column: "Content",
                value: @"Aldo: In Africa, tutte le mattine, quando sorge il sole, una gazzella muore. 
Clara: Muore? 
Aldo: Si sveglia già morta, perché si vede che non stava molto bene il giorno prima e allora... Comunque, sempre in Africa, no? Tutte le mattine, quando sorge il sole, un leone, appena si sveglia, comincia a correre per evitare di fare la fine della gazzella che è morta il giorno prima. E poi, correndo, vede che c'è la gazzella morta il giorno prima lì e visto che... ""Che cosa corro a fare? Mi fermo e gli do due mozzicate"". Comunque, dove voglio arrivare? Non è importante che tu sei un crotalo o un pavone. L'importante è che se muori, me lo dici prima.[1]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 34,
                column: "Content",
                value: @"Aldo: Pronto, chi è? Chi? Giovanni Storti? E lei chi è? Ah, è la moglie.
Giovanni: Mia moglie.
Aldo: Stai fermo con le mani! Non lo so se ha sbagliato numero ma sicuramente ha sbagliato persona, o forse ha sbagliato numero ma ha trovato la persona giusta, o ... mi'! M'ha mandato a fanculo! Lo stesso carattere del marito! Mi', che famiglia! Sequestrato... anzi eliminato! [Riferito al telefonino che butta dal finestrino]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 35,
                column: "Content",
                value: @"Catania: Minchia già incazzato?? 
Giacomo: Sì, dai. Metti in moto che siamo già in ritardo. 
Catania: Ah, senti, c'è stato un cambiamento nel programma. 
Giacomo: Che cambiamento? 
Catania: Prima di passare dal carcere, devo fare una commissione. 
Giacomo: Catania cosa ti stai inventando stavolta? 
Catania: Quanto bene mi vuoi Giacomo? dammi la mano... e dammi sta cazzo di mano!... 
Giacomo: Ma dai! 
Catania: Hai sentito? Sai cosa vuol dire quando batte così il cuore? Guardami in faccia quando ti parlo. Lo sai cosa vuol dire? 
Giacomo: Ho paura di saperlo, Catania. 
Catania: Quanti favori t'ho fatto Giacomo eh?! Dimmi, quanti favori t'ho fatto?? 
Giacomo: Devo essere sincero? 
Catania: Non far lo stronzo... Giacomo ti prego non far lo stronzo! Io sto mettendo la mia vita nelle tue mani e tu fai lo stronzo? Non lo fare perché io per te... io per te... e dammi un bacio... quanto cazzo di bene ti voglio!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 36,
                column: "Content",
                value: @"Giacomo: Catania hai letto il regolamento? Non posso recuperare un delinquente da solo. 
Catania: Ecco quando fai così mi fai davvero incazzare! Ma come?! Tu sei il mio migliore amico io per te finirei pure in galera e tu? Come mi stai trattando? No dimmi come mi stai trattando??? Vaffanculo Giacomo... e dammi un bacio. 
Giacomo: Basta con 'sti baci e guarda sta strada! Piuttosto dimmi chi è stavolta e la facciamo finita. 
Catania: Aaaah perché tu credi che ci sia di mezzo una donna eh?! No, questa non è una donna. Questa è un'opera d'arte... una scultura... bella come una statua, una statua di... va bè adesso non mi viene in mente nemmeno il nome, ma guarda, ti giuro è perfetta... ecco io posso scendere anche qui ora... 
Giacomo: Catania... 
Catania: Io faccio un favore a te e tu uno a me. 
Giacomo: Catania... 
Catania: Così è la vita... a proposito: l'hai finito il tuo libro? Vedi che cazzo d'amico che sono! Tutto mi ricordo tutto! 
Giacomo: Allora... Allora adesso tu fai un favore a me: scendi dalla macchina e ti levi dalle palle, su andare! 
Catania: Allora ci vediamo qui alle undici.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 37,
                column: "Content",
                value: @"Aldo: Vuoi un po' di cheeseburger? 
Giacomo: No, grazie. Io faccio una dieta dissociata; cerco di non mischiare i carboidrati con le proteine..sai, perché se gli enzimi dei carboidrati... 
Aldo: Mii, e che devi farmi la cartella clinica?!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 38,
                column: "Content",
                value: @"Aldo: Ma perché? Perché, perché, perché mi fai questo? Perché mi devi mettere sempre i bastoni fra le ruote, eh? Mentre sto operando, oltretutto!
Marito della partoriente: È uscita la testa! È uscita la testa!
Aldo: Eh Ho capito, un minuto! Un minuto! Ha aspettato undici mesi, può aspettare anche un minuto, no? E tutto io devo fare? Ritorniamo a noi: Perché? Eh? Fammi vedere le mani. [Giovanni fa segno di no con la testa] Fammi vedere le mani, imperativo categorico assoluto! [Giovanni gli fa vedere le mani] O tu, o io? Che c'è scritto?
Giovanni: Niente!
Aldo: O io o tu?
Giovanni: Sì, è un gioco di parole...
Aldo: E come si risolve?
Giacomo: Ma niente, è che devi leggerle al contrario... ed esce scritto aiuto, c'è scritto.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 39,
                column: "Content",
                value: @"Aldo [mangiando un hamburger]: Il nettare degli dei. E il settimo giorno, Dio creò il cheeseburger. [Rivolgendosi a Giovanni] Ma come fa a non piacert... [Gli parte inavvertitamente un colpo dalla pistola che ha in mano. Il retro della macchina si sporca di rosso] Maria! Che ho fatto, Maria, che ho fatto? Gli ho spappolato la faccia, gli ho spappolato! Gli ho spappolato il cervello!
Giovanni: Non sento più niente! Oddio, non sento più niente! Non sento dolore!
Aldo: Sento che già il cadavere puzza! Sta frollando? Sta frollando?
Giovanni: Non sento più niente!
Giacomo: Ci credo che non senti niente, deficienti! È ketchup! Hai assassinato il sacchetto d'hamburger, hai assassinato!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 40,
                column: "Content",
                value: @"Aldo [puntandosi la pistola alla tempia]: Datemi un buon motivo per non farlo.
Giovanni: Be', adesso non me ne viene in mente neanche uno, però pensandoci bene, magari...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 41,
                column: "Content",
                value: @"Giovanni [riferendosi ad Aldo]: Oh cacchio, è con una ragazza?!
Giacomo: Sì.
Giovanni: Ma come sì... C'è lì il mostro di Dusseldorf con una ragazza e tu non fai niente, non agisci?
Giacomo: Perché?
Giovanni: Ma come perché, è un delinquente questo qua!
Giacomo: Ma scusa, adesso secondo te uno basta che finisca una volta in galera e diventa uno stupratore... Va' che tu, della natura umana, non capisci proprio un cazzo!
Giovanni: Senti, natura umana, è due giorni che te lo voglio dire! Sei proprio un cretino, va bene?
Giacomo: Che cosa hai detto?
Giovanni: Ho detto che sei un cretino, hai capito bene!
Giacomo: Guarda, faccio finta di non sentire! E poi comunque ti ricordo che stai parlando con un pubblico ufficiale!
Giovanni [ride]: Ma pubblico ufficiale che cosa, ma ti sei visto? Ma sei vestito come uno spaventa-passeri, e sai perché? Perché sei uno spaventa-passeri!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 42,
                column: "Content",
                value: @"Aldo: Ti chiami Clara?! Bellissimo nome! Pensa che quando ero bambino, e quando dico bambino... dico bambino! Conoscevo un'amica che si chiamava Francesca... E indovina come la chiamavo?
Clara: Clara.
Aldo: Eh no. Si chiamava Francesca... E la chiamavo Francesca.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 43,
                column: "Content",
                value: @"Giovanni: Hai capito?
Aldo: Non sono mica sordo!
Giovanni: Ciccio, quello è sentire, capire è un'altra cosa!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 44,
                column: "Content",
                value: @"Giovanni [discutendo sulla reazione dei parenti alle loro morti]: Ma sì... Il discorso di fondo è uno solo: non è che tutti gli esseri umani di fronte al dolore hanno la stessa reazione. Non so, prendi una vedova araba: urla, strepita, si strappa i capelli, si rotola... Una svedese no! Al massimo una lacrimuccia. Non è che soffra meno, è una reazione diversa di fronte al dolore. Mia moglie ha avuto una reazione di questo tipo.
Giacomo: Ma sì, un po' svedese. Come mia sorella e mio cognato.
Giovanni: Be', be' no eh, tua sorella e tuo cognato sono proprio dei bei bastardi. 
Giacomo: Ma come bastardi?
Giovanni: Ma sì, scusa, sei appena morto e ti affittano la camera e buttano il libro della tua vita nella spazzatura? Se non son bastardi questi qua, dai...
Giacomo: Scusa, e allora tua moglie?
Giovanni: Cosa vuol dire, lì è una reazione diversa.
Giacomo: Ma reazione diversa che cosa?! Scusa, sei morto da un giorno e si mette a trombare con un altro, dai!
Giovanni: Ma cosa vuol dire? È lo shock!
Giacomo: Ma lo shock di che cosa? Giovanni, è brutto sentirselo dire, ma tua moglie è proprio un bel puttanone!
Giovanni: Wè Giacomo, piano con le parole eh! Ahahahah, questa è bella! Mia moglie è un puttanone! Ma dai, mi fai ridere mi fai, ecco cosa mi fai! Adesso mia moglie è un puttanone... Ma pensa te! Mia moglie è un puttanone... [Con tono sempre più convinto] Mia moglie è un puttanone...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 45,
                column: "Content",
                value: @"Giacomo: Non mi vedi da tre anni e mi sbatti la porta in faccia!?
Giovanni: Che cosa vuoi?
Giacomo: Senti, lo so che è tardi, però è successa una roba...
Giovanni [con tono aggressivo]: Che cazzo vuoi?!
Giacomo: Aldo sta male!
Aldo [voce fuori campo]: Eppure, tre anni fa le cose erano molto diverse!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 46,
                column: "Content",
                value: @"Aldo: Oh, eh, Giovanni, quando vuoi venire non ti fare scrupoli, eh? Questa casa è sempre aperta per te. Eh? Non ti fare scrupoli, vieni quando vuoi, hai capito?
Giovanni: Scrupoli, è mia! Non è che...
Aldo: Comunque, magari una telefonatina prima, eh? Oh, Giacomino, anche tu, quando vuoi venire vieni, qua la porta... Allora, qui gente che entra, gente che esce, la facciamo diventare quello che vogliamo!
Giovanni: No!
Aldo: Mangiamo, beviamo, di giorno, di notte...
Giovanni: No!
Aldo: Ci ubriachiamo, eh, spacchiamo tutto, la radiamo al suolo questa merda di casa! 
Giovanni: Allora, no, no, no, un attimo! Mettiamo le cose in chiaro!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 47,
                column: "Content",
                value: @"Giacomo: Allora, stavolta mi è proprio venuta una grande bella idea: e se rappresentassimo il Cyrano de Bergerac? 
Aldo: Ma Giacomino, Giacomino, sempre con queste americanate, finiscila, va! 
Giacomo: Americanate che cosa?! È francese, il Cyrano! 
Aldo: C'hai sempre ragione tu...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 48,
                column: "Content",
                value: @"Giacomo: C'ho un turno di doppiaggio, Aldo. 
Giovanni: Cosa, devi scoreggiare mentre passa un treno? 
Giacomo: Ha parlato il mimetto Tutankamon. Perché non ci vai te allora? 
Giovanni: Che problema c'è? 
Giacomo: Eh, vai! 
Aldo [triste per ciò che stava per succedere]: Giovanni, fallo tu, ti prego... [Giovanni si rassegna] Grazie! [lo bacia]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 49,
                column: "Content",
                value: @"Giacomo: Va' che non ci vuole niente a scaricare le donne degli altri. L'unica cosa veramente importante è che non la lasci parlare: non deve avere il tempo di parlare. Devi essere lucido, freddo, distaccato. 
Giovanni: Tipo Zoff? 
Giacomo: Mmh, tipo Zoff.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 50,
                column: "Content",
                value: @"[Pensando a una terza persona per la cena]
Giacomo: Che poi, non è proprio doppia coppia doppia coppia, eh.
Aldo: In che senso?
Giacomo: Nel senso che c'è una loro amica che si è appena trasferita lì, non ho capito bene... Cioè, bisogna trovare un terzo amico per lei, se no non se ne fa niente...
Aldo: E che problema c'è? Giovanni... mi passi il formaggio, per favore? Ci sarebbe Lello.
Giacomo: Lello? Lello è pesante, dai! 
Aldo: Beh, un po' pensante è vero... 
Giacomo: Logorroico. 
Aldo: Eh, sarà pure logorroico ma parla troppo. Allora Brio. 
Giacomo: Brio potrebbe andar bene... se si lavasse!
Aldo: No, non gli puoi chiedere una cosa del genere a Brio! Allora Rudy!
Giacomo: Rudy? Quello che frega le autoradio?
Aldo: Non quel Rudy lì, l'altro...
Giacomo: Non starai parlando di quello che fa la gara di rutti?!
Aldo: Il due volte campione italiano di rutti!
Giacomo: Cioè, portiam fuori uno che fa i rutti?! 
Aldo: Conosciamo un vip, buttiamolo via!
Giacomo: Vabbè, ho già capito che di questa roba non se ne fa niente... 
Aldo: Ma che cretino! Uno c'ha la soluzione davanti agli occhi e non se ne avvede! Giovanni... non è che conosci qualcuno? Un amico? Un parente?
Giovanni: Non conosco nessuno! [sbattendo il tovagliolo sul tavolo]
Aldo: Neanche un primate col pollice opponibile?
Giovanni: Ma va a cagare, va!
Giacomo: Ma dai Giova, era uno scherzo!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 51,
                column: "Content",
                value: @"[Parlando della cena a tre, al supermercato]
Giovanni: Allora, io... venire vengo perché ormai ho promesso, giusto? Però qualcuno ha visto la ragazza? Non è che mi capita la solita pantegana?
Aldo: Allora, ti capita quello che ti deve capitare, la pantegana o il cane-lupo che sia, comunque stiamo facendo un favore a Giacomino.
Giovanni: E facciamogli 'sto favore...
Aldo: E facciamogli 'sto favore, e non se ne parla più! Allora, torniamo a noi. Giacomino comunque, puoi leggere tutti i libri che vuoi, cosa che mi guardo bene dal fare...
Giacomo: Vantati, eh...
Aldo: Comunque Marco Ferradini è un tuttologo sull'amore.
Giovanni: Allora, fatemi capire bene. La cena la facciamo per Giacomino, giusto? Quindi paga lui?
Aldo: No! Ognuno mette il suo, braccino corto!
Giovanni: Vabbè, io la mia parte l'ho già messa.
Giacomo: Messo cosa?
Giovanni: Le cinquecento lire del carrello!
Giacomo: Va be' ma poi te le riprendi!
Giovanni: Intanto lì è un capitale immobilizzato, e gli interessi, pemm, si impennano!
Giacomo: Interessi cosa?
Giovanni: Lascia perdere, cosa ne sai tu di economia, Giacomo?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 52,
                column: "Content",
                value: @"Aldo: Continuiamo, va'. Fuori dal letto...? Fuori dal letto? 
Giacomo: Nessuno è perfetto. 
Aldo [urlando]: Nessuna pietà! Nessuna pietà! Ma come devo fare con te? Attitudini sull'amore nessuna! [mentre camminano per i reparti di un supermercato, Aldo cerca di spiegare a Giacomo come deve trattare una donna seguendo una nota canzone di Marco Ferradini, di cui Giacomo non riesce a ricordare le parole]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 53,
                column: "Content",
                value: @"Marina: Giovanni, non senti uno strano odore?
Giovanni: Di cosa?
Marina: Di bruciato?
Giovanni: Ah sì è vero, c'è l'arrosto nel forno.
Aldo: Lo sento pure io. 
Silvana: No no, io non sento proprio odore di bruciato. 
Aldo: Eh, c'avrai le mucose andate...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 54,
                column: "Content",
                value: @"Beppe il ladro: Dammi il portafoglio!
Aldo: Ok, ma non mi puntare l'arma addosso.
Beppe il ladro [prende e apre il portafoglio]: Ma è vuoto?!
Aldo: Eh, tu il portafoglio mi hai chiesto...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 55,
                column: "Content",
                value: @"Giacomo: Smettila di buttarti giù, quante volte te lo devo dire, vedrai che va tutto a posto! Del resto tu sei un ragazzo intelligente, eh, si vede! 
Beppe: Da cosa? 
Giacomo: Beppe, son frasi fatte, è per dire... Non è che devi star lì ad approfondire tutto...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 56,
                column: "Content",
                value: @"Giovanni Ciao Beppe! 
Beppe: Magari ci sentiamo... 
Giovanni: Ma sì, figurati! 
Beppe: Allora buonanotte, eh, ciao. 
Giovanni: Buonanotte... [ferma Beppe che se ne stava andando con la sua bici] Ciccio! Eh, eh! La bicicletta! 
Beppe: Aah... 
Giovanni: Eh, ""aah""... E intanto, eh, track! Ti ci sei affezionato! Ecco, Beppe, cerca di perdere il vizio, eh!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 57,
                column: "Content",
                value: @"Giacomo: Giovanni guarda, non so proprio come dirtelo, ma i mobili di tua madre fan veramente cagare. 
Giovanni: Ma cosa ne vuoi capire tu Giacomo, non sai neanche cos'è una pialla! 
Giacomo: Ma cosa c'entra? Non è che uno deve costruire i mobili per saperli apprezzare! 
Giovanni: Eh no, caro! Chi sa fare, sa capire! 
Giacomo: Ma che cazzo di proverbio è? 
Giovanni: Non è un proverbio, è la vita, Giacomo.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 58,
                column: "Content",
                value: @"Giacomo: Abbiamo incontrato Francesca che piangeva! Cosa le hai fatto? 
Aldo: Niente! 
Giacomo: Senti furbino, non è che per caso ti sei messo anche con lei? 
Aldo: No! 
Giacomo: Di' la verità! 
Aldo: Sì... 
Giovanni: Scommetto che ti ha beccato con un'altra eh? 
Aldo: No! 
Giovanni: Di' la verità! 
Aldo: Sì...
Giacomo: Certo che tu sei veramente il campione olimpico dei minchioni!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 59,
                column: "Content",
                value: @"Giacomo: Be', immagino Elena che tu abbia già avuto esperienze teatrali...
Candidata attrice: Io sì. E voi?
[I tre si guardano imbarazzati]
Giacomo: Comunque la commedia sarebbe il Cyrano di Bergerac.
Aldo: Sì, Bergerac... Che sarebbe anche l'autore. [la candidata se ne va]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 60,
                column: "Content",
                value: @"Giacomo: Immagino che tu abbia già avuto esperienze di teatro... 
Candidata attrice: Be', sì... ho lavorato con Albertazzi... 
Aldo: Però... Albertazzi... il grande Albertazzi... il grande e irreprensibile Albertazzi! Mammamia, non sapevo che facesse anche teatro. [la candidata se ne va]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 61,
                column: "Content",
                value: @"Giacomo: Certo che è una situazione kafkiana... 
Aldo: Ma, precisamente, questo Kafkian, chi è?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 62,
                column: "Content",
                value: @"Giovanni [al venditore di snack sul treno]: Che tipo di panini avete? 
Venditore: Abbiamo prosciutto, formaggio, prosciutto e formaggio... 
Giovanni: Prosciutto cotto o crudo? 
Venditore: Cotto. 
Giovanni: No, non mi piace... e formaggio? 
Venditore: Formaggio. 
Giovanni: Ho capito, ci son tanti tipi di formaggio: stagionato, molle, filante... 
Venditore: Senta, io stamattina mi sono alzato alle sei. 
Giovanni: Eh, e io alle cinque! 
Venditore: Sì. A che ora è andato a letto? 
Giovanni: Non so, sarà stato undici e mezza, mezzanotte...
Venditore: Alle due. 
Giovanni: Ah be' allora... formaggio! Mi scusi. 
Venditore: Bravo. 
Giovanni: Me lo può scaldare per favore?
Venditore: Certo. [prende il panino e lo mette contro il finestrino su cui batte il sole] Se ha una mezz'oretta...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 63,
                column: "Content",
                value: @"Giovanni: Io ero a Francoforte, e tu l'hai baciata!? 
Giacomo: Sì... ma Giovanni... 
Giovanni: Stai zitto! Io ero a Francoforte, e tu l'hai baciata!? Mi fai schifo, Giacomo! 
Giacomo: Ma Giovanni, posso spiegare... 
Giovanni: Ma spiegare che cosa? Sei veramente un bastardo, Giacomo! Non ti voglio più vedere! Per me non esisti più! 
Aldo: Ma dai, Giovanni! È solo un bacio... 
Giovanni: Qualcuno t'ha chiesto qualcosa? 
Aldo [si giustifica perplesso]: No... un bacio... è solo un apostrofo rosa fra le parole franco e forte! 
Giovanni: Ma che cazzo stai dicendo? Mi prendi anche per il culo? 
Aldo: Sono confuso, scusa... 
Giovanni: E poi tu lo sapevi e non mi hai detto niente? 
Aldo: No, io non lo sapevo... 
Giovanni [sempre più arrabbiato]: Anzi peggio: tu mi hai mandato a Francoforte per lasciare lui [spingendo la testa di Giacomo] da solo!!! 
Aldo: Guarda, stai creando un equivoco, sei arrabbiato... 
Giovanni: Guarda, mi fai schifo, anzi fate schifo tutti e due... 
Aldo: Ti prego, cerca di ragionare... 
Giovanni: Ma stai zitto, taci! Per favore, taci, taci!! Tu sei capace solo di vivere sulle spalle della gente! Tu sei un approfittatore! Sei un parassita! [alza il tono di voce, mentre Aldo abbassa lo sguardo] Anzi, sai cosa ti dico adesso? Tu vai al mio magazzino, prendi la tua roba e non ti fai più vedere! Hai capito? La pacchia è finita!! Chiaro?! 
Aldo [tenendo basso lo sguardo]: E la commedia? 
Giovanni: La commedia?! Guarda la tua commedia, guarda... [prende una spada di legno e comincia a distruggere tutta la scenografia con rabbia] Eccola! Guarda la tua commedia! La commedia del cazzo!!! [butta giù un albero della scenografia e se ne va]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 64,
                column: "Content",
                value: @"Giacomo: Giovanni, ma sono fasi del rapporto queste qua. 
Giovanni: Sì, fasi del rapporto... 
Giacomo: Giovanni, sono cose che si dicono.
Giovanni: Eh, cose che si dicono...
Giacomo: Senti Giovanni, però, non c'è bisogno di ripetere tutto quello che ti dico, il dialogo è fatto di botta e risposta!
Giovanni: Eh si, botta e risposta... Botta e risposta... 
Aldo: Giacomino, anche tu, sei bravissimo a scarricare, ma per riconciliare una coppia sei una merda proprio!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 65,
                column: "Content",
                value: @"Zia di Aldo: Spero solo di sentire presto gli zoccoli del cavallo di San Bartolomeo. 
Giacomo e Giovanni: Eh, sì... 
Zia di Aldo: Che venga a pigghiasselo col suo sacco nero! Così smette di soffrire! 
Giacomo e Giovanni: Signora, un po' di ottimismo, però!
Zia di Aldo: E questo ottimismo è! 
Giovanni: Ah questo è ottimismo? Chissà il resto...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 66,
                column: "Content",
                value: @"John: Che stai facendo, Jack? Che stai facendo?
Jack: Johnny... Smarties contro Anfetamine, no? [si vedono appunto degli Smarties e delle pasticche di anfetamine disposti su una scacchiera]
John: E ti sembra il momento?
Jack: È sempre il momento!
John [esegue alcune mosse per far concludere la partita]: Partita finita.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 67,
                column: "Content",
                value: @"Al [vedendo ridere John e Jack]: Che c'è da ridere?
John: Niente, Al...
Al: E fate ridere un po' anche me!
John: No, è che... tuo fratello, no?
Al: Che c'hai da dire su mio fratello, parla.
John: Niente, così, dico che... A conoscerlo superficialmente... Tuo fratello è un po'... Eh? [si scambia uno sguardo d'intesa con Jack e ride]
Al: È un po' cosa? Parla!
John: Niente, dai, lasciamo perdere, non parliamone più.
Al: No, parliamone, parliamone, stiamo parlando di mio fratello e parliamone, giusto?
Jack: Allora Al, ti sta dicendo che... Tuo fratello... Ti sta dicendo che tuo fratello... è un ricchione!
Al: Mio fratello non è un ricchione! È raffinato!
Jack: Cos'è tuo fratello?
Al: Raffinato! E comunque stiamo facendo un lavoro, facciamolo e basta, va bene? C'è da ammazzare qualcuno? Ammazziamolo e basta!
Jack: Mii, che clima... E come si fa ad ammazzare la gente con questo clima? Che siamo, delle macchine?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 68,
                column: "Content",
                value: @"Al: Johnny, vai dritto verso la discarica.
Frankie: No, la discarica no! Lo so che cosa succede alla discarica!
John: E che cosa succede alla discarica, Frankie? Che si butta la spazzatura!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 69,
                column: "Content",
                value: @"John: E vabbè va', oggi mi sento di buon umore. Frankie, se risponderai a una domandina facile facile, te ne torni a casa dai tuoi bambini, eh?
Frankie: Grazie Johnny, ti dico tutto quello che vuoi sapere.
John: Ecco, allora dimmi: qual è la capitale della Birmania?
Frankie [stupito]: Ma... come... la...
John: La capitale della Birmania, Frankie!
Frankie: Ragazzi, ma perché fate così, come faccio a sapere la capitale della Birmania?
John: Ahi, ahi, ahi, che peccato, che peccato, che peccato, Frankie! Tra l'altro potevi dire una cosa qualsiasi che a noi andava bene! Chi minchia la sa la capitale della Birmania, Frankie?!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 70,
                column: "Content",
                value: @"Al: ...Ooh, non sai quale cosa si può fare, Johnny...? ...Non lo possiamo mandare a casa? [Frankie Culo di gomma]
John: Le regole sono regole, Al.
Jack: E c'ha ragione, Johnny, che mondo sarebbe senza le regole, eh?
Johnny: Poi anche volendo, come facciamo col boss? Quello vuole il suo cuore su un piatto d'argento.
Al: E che problema c'è? Ammazziamo un cerbiatto e gli portiamo il suo cuore al boss. ...non avete visto Biancaneve e i sette nani?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 71,
                column: "Content",
                value: @"[Dopo aver ucciso il presunto Frankie Culo di gomma]
John: Scusa Al, ma... non avevi detto che volevi salvargli la vita?
Al: Sì, Johnny... E dove minchia lo troviamo un cerbiatto a New York?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 72,
                column: "Content",
                value: @"John: Allora, vediamo domani. Ore 4: far saltare la tintoria dei Jefferson. E mi raccomando Jack, non come l'altra volta che ti sei dimenticato il numero e hai fatto saltare un negozio a caso!
Jack: Sì, però poi era quello giusto!
John: Quella è fortuna, non si lavora così, siamo professionisti!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 73,
                column: "Content",
                value: @"Al: Ti sento, Diavolo, che sei in questa casa! Entra in me! Entra in me, Diavolo! Satana di un satanasso! Io ti scaccio-da questa-casa-male-detta!! Io ti posso affrontare! Hai capito?! Vai via, Satana!!
John: Che minchia sta succedendo, Jack?
Jack: Minchia, Johnny, mi sto ammazzando dalle risate!
Al: Rientra nelle tenebre! Entra in me! Entra in me!
John: Ma che gli hai fatto, Jack?
Jack: Ma niente, Johnny, si è addormentato, poi quando s'è svegliato gli ho fatto credere di essere un esorcista! Ah ah ah!
Al: So che sei qua!! Non mi fai paura!! Abbandona!! Rientra!!! Nelle!!! Tenebre!!!
John: Ma sei impazzito??
Jack: Mi sto ammazzando dalle risate, Johnny! Che bella vita che facciamo, Johnny! Guarda che ridere fa bene! E poi, oh, il bello deve ancora avvenire, eheheheh! [silenzio. Al guarda John in modo strano credendo che fosse il Diavolo]
Jack [sottovoce a John]: E credici un pochino...
Al: Diavolo, ti ho trovato finalmente. Esci da questo corpo deforme. Entra in me. Cosa sei...? Entra in me! Abbandona questo grottesco involucro ed entra in me! Entra in me, adesso...! [John lo colpisce sul naso con il calcio della pistola e lo fa cadere per terra privo di sensi]
John: Come faccio con te, Jack? Come faccio?
Jack: E che ne so, Johnny...
John: Due ore di lavoro buttate via! Quante volte te l'ho detto? Non è un giocattolo, non è un giocattolo!
Jack: Ma mi annoio, Johnny!
John: Jack! Jack! Jack!
Jack: Comunque faceva ridere, di' la verità!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 74,
                column: "Content",
                value: @"Jack: Ma come facevi a sapere che mi piaceva proprio la pistola? 
Al: Eh, tu tre gusti hai! La pistola, le anfetamine e la torta di Melissa.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 75,
                column: "Content",
                value: @"John: Jack, quante volte te lo devo dire, non si spara ai cani! 
Jack: E perché? 
John: Perché sono animali superiori! 
Jack: E chi l'ha detto? 
John: Ma la scienza lo dice, Jack, la scienza! 
Jack: La scienza? 
John: Ma che ne sai tu di scienza!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 76,
                column: "Content",
                value: @"John: [Jack spara alcuni colpi in aria per la casa] Ma che fai, Jack? Che fai? 
Jack: Johnny, ho guardato il libro di Carabbaggio? E lasciami provare 'sta pistola! [Continua a sparare e cade un quadro] 
John: Minchia, quante volte ti ho detto che non si spara in casa, Jack? Quante? 
Jack: Cinque? 
John: No, sette! 
Jack: Minchia, non mi sta in testa...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 77,
                column: "Content",
                value: @"John: [La zia di San Genovese muore uccisa davanti ai suoi occhi, e girandosi guarda Jack che è sotto shock] Ma Jack, che hai fatto? 
Jack: Ma Johnny, non ho fatto niente, ho solo fatto così! [Alza le braccia e dalla cinta parte un colpo di pistola che uccide un autista di bus] MARIA! 
John: Jack, ma quante volte ti ho detto di non tenere la canna della pistola verso l'alto? Quante? 
Jack: Cinque! 
John: No, sette! 
Jack: Minchia, non mi sta in testa, Johnny!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 78,
                column: "Content",
                value: @"Al: [Vede Jack che prende una statuetta di ceramica da sopra la TV] Jack, non mettere le tue mani appiccicose dappertutto!! Lascia stare le cose dove stanno, perché sono cose delicate, hai capito? 
Jack: ""Delicate"" queste cacate!? [Riferendosi alla statua che ha in mano] 
Al: Non sono cagate! Quello è un Capodimonte originale, roba ""italiana""! Tu che ne capisci? Costa un mucchio di soldi... Posala dove l'hai trovata!! 
Jack: [Confuso, rimette la statua al suo posto] L'arte, non la capirò mai...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 79,
                column: "Content",
                value: @"Al: Non preoccuparti, io non voglio immischiarmi nelle vostre cose, ti chiedo solo di parlargli e di dirli che non sei innamorato di lui... se è così...
John: Al, fidati, è così!
Al: E chi ha detto il contrario? Ti chiedo solo di parlagli e di dirgli che i suoi sentimenti per te non sono corrisposti... se è così... 0
John: Al, se dici un'altra volta ""se è così"" ti sparo in testa! È così!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 80,
                column: "Content",
                value: @"Jack: Johnny, però non è che te la puoi pigliare sempre con me, eh? E comunque che credi che io non ci abbia pensato? 
John: Pensato! Jack, ma non ti si è ancora chiusa la fontanella, che vuoi pensare?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 81,
                column: "Content",
                value: @"Jack: Johnny, stai calmo, dammi retta, che con la calma si ottiene tutto... allora Al, ascoltami bene, eh, è facile: adesso tu esci da quella finestra, ti arrampichi sul cornicione ed entri nella stanza di Sam Genovese. 
Al: Cornicione, finestra, stanza... questo lo so. 
Jack: Ecco, è un gioco da ragazzi per te, no? Quando sarai entrato dentro la stanza... 
Al: Scusami, Jack, ma perché non entriamo dalla porta come tutti quanti? 
Jack: E Al c'ha ragione! Perché non c'abbiamo pensato? Perché non entriamo direttamente dalla porta? E magari ci presentiamo con dei sandwich, delle birrette, chiamiamo pure una fanfara, suoniamo le trombe, spariamo per aria! E che credi, che se si poteva entrare dalla porta io e lui non ci pensavamo?! Che siamo, due cretini, io e lui?! È arrivato Sherlock Holmes, è arrivato!
John [tira qualche ceffone a Jack per calmarlo]: Calma Jack! Calma!
Jack [calmatosi]: Scusa Johnny...
John [ad Al]: Non possiamo entrare dalla porta perché davanti alla porta ci sono Tom Schiena di Legno e Sam Mani di Merda, hai capito?
Al: Scommetto che quello che gli cadono le cose è Mani di Merda.
Jack: No, quello è Tom Schiena di Legno, per quello non si può chinare.
Al: E perché a quell'altro lo chiamano Sam Mani di Merda?
Jack: Che c'entra? Quello è perché ci puzzano le mani.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 82,
                column: "Content",
                value: @"Al: [Mentre percorre il cornicione rischia di cadere giù ma si riattacca al muro] Gesù... Perché proprio io?
John: Non guardare sotto, Al. Non guardare sotto!
Jack: Stai andando benissimo, Al. Bravo, bravo! [a John] Johnny non ce la faremo mai! Genovese sta per arrivare!
John: Che sono cretino, Jack? Ho bloccato l'ascensore!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 83,
                column: "Content",
                value: @"Al: [È arrivato alla fine del cornicione ma ha paura a saltare sul traliccio dell'insegna dell'albergo] Ho paura, non ce la posso fare!
John: È facile Al, c'è il traliccio, è facile!
Al: Io torno indietro!
Jack: E salta, Al! Che devo fare, ti devo sparare??");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 84,
                column: "Content",
                value: @"John: Non è successo niente, Al, bravo, non è successo niente... 
Al: Mii, non è successo niente? E che doveva succedere, doveva cadere il palazzo?!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 85,
                column: "Content",
                value: @"John: E poi portare in giro per la città la zia di Sam Genovese è un grande onore. 
Jack: Eh, sai che onore! L'anno scorso è toccato a Nick il Demente... 
John [spazientito per il costante parlare di Jack]: Taci Jack, taci e basta! Non ne posso più quando parli! Adesso andiamo a prendere questa vecchia, la portiamo in giro per la città, la facciamo divertire, siamo gentili, siamo deferenti, la portiamo da Tiffany, la portiamo a prendere il tè con le cassatelle, eh? E poi la riportiamo a casa. E alle 5 p.m. cascasse il mondo saremo davanti allo Stardust, ok?! 
Jack: Johnny, mi hai convinto, andiamoci a pigliare sta minchia di vecchia. 
John [su tutte le furie]: Allora, siamo gentili, non diciamo parolacce, non diciamo volgarità e soprattutto [dà due colpi al clacson per la rabbia] non diciamo vecchia! Ok, Jack? Ok?! 
Al: [Ironico] E allora andiamo a prendere questa teenager.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 86,
                column: "Content",
                value: @"John: Forse m'è venuta un'idea... 
Jack: Gazpacho con la cocaina?! [John gli dà uno scappellotto]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 87,
                column: "Content",
                value: @"John: Sei contento?
Jack: Ti sembro scontento, Johnny? Minchia, Carabbaggio... 
John: Caravaggio, Jack! 
Jack: Sii... [ad Al] Oh, comunque Al, grazie per questo regalo che è bellissimo! [la pistola] 
Al: Dai, digli che ti piace! 
Jack [a John, che sembra triste]: Ma sì, Johnny, mi piace! Minchia... [ad Al] Senti, e... i colpi? 
Al: Eh, i colpi! I colpi... pensavo che li prendeva Johnny! 
Jack: Johnny...?! 
Johnny: Eh... io ero indeciso tra i colpi e Caravaggio... 
Jack: E hai scelto il Carabbaggio...?! [John annuisce, e Jack si scandalizza] Che compleanno di merda! [lancia la pistola sul tavolo]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 88,
                column: "Content",
                value: @"Boss: Dovevate ammazzare una spia... e avete ammazzato un barbiere... non so proprio più come fare con voi, ragazzi... due settimane fa avete chiesto il pizzo ai negozi sbagliati... e oggi mi ammazzate un barbiere!! 
Jack: Eh, poi ci sarebbe anche la storia del bourbon... 
Boss: Quale bourbon? 
Jack: Eh quella partita di bourbon che dovevamo consegnare, e invece... ci siamo scolati al party di Billy Piorrea.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 89,
                column: "Content",
                value: @"Boss: Ora lancerò questi dadi, forza, ditemelo un numero! Se uscirà proprio quel numero avrete salva la vita. Avanti, qual è il vostro numero fortunato, eh? 
Jack: Cinquanta! [John tira uno schiaffo a Jack] 
John: Otto, Boss, il nostro numero fortunato è otto. [il Boss lancia i dadi ed escono i numeri quattro e tre. Al, John e Jack rimangono turbati] 
Boss: Quattro e tre... otto... che botta di culo! 
Jack: Ma scusi Boss, ma quattro e tre non... [Jack riceve uno schiaffo da John e un calcio da Al] 
John: Scusi per l'interruzione, boss!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 90,
                column: "Content",
                value: @"Jack: Allora, Al, ascoltami bene: era venerdì. Eravamo al Drive In di Coney Island. Eravamo lì perché il boss...
John: Jack, se inizi sempre dalla fine, questo [riferendosi ad Al] non capisce niente. Bisogna iniziare dall'inizio, lo dice la parola stessa.
Jack: E allora fai una cosa, Al: ascolta il professorone. [indica John e se ne va]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 91,
                column: "Content",
                value: @"Al: Ma... ditemi un'ultima cosa... quello che mi avete raccontato... è tutto inventato?
[John e Jack fanno per replicare, quando una voce fuori campo li interrompe chiamando Al col suo vero nome]
Herbert: Calogero! Calogero!
Jack [stringendo le spalle]: Eh... Al... non proprio tutto tutto...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 92,
                column: "Content",
                value: @"John: Questo è il piano. Tu esci dalla finestra... fai venti metri di cornicione... e arrivi alla scritta dell'hotel. Ti arrampichi sul traliccio, superi l'insegna... e arrivi al cornicione del piano di sopra. Quando arrivi all'ultima finestra... no quella, quell'altra! La forzerai con un coltellino. E ti introdurrai come una faina nella stanza del boss. Una volta nella stanza, ti infilerai nell'armadio.
Al: Quindi io devo stare nell'armadio?
John: Esatto.
Al: Sono allergico alla naftalina?
John: No.
Al: Sono claustrofobico?
John: No.
Al [sorride]: Minchia, Johnny, hai proprio pensato a tutto! Dopodiché, mentre io sono nell'armadio arriverà Genovese.
John: Esatto.
Al: E quello è il momento, esco dall'armadio e lo ammazzo!
John: Non lo devi ammazzare, Al, dobbiamo salvargli la vita!!! Se lo ammazzi, avremmo addosso tutta la Mafia di New York!
Al: Mmmm...! ma com'è che questa cosa non mi entra in testa? Salvare la vita, salvare la vita, salvare la vita! È così semplice!
John: Allora Al, quando arriverà Genovese, tu non ti devi muovere, devi solo stare fermo ad aspettare! A un certo punto lui ordinerà la cena! Ed è lì che entriamo in scena noi, io e Jack! 
Al: E come facciamo a sapere che Genovese ordinerà la cena? 
Jack: Mii, Al, sono tre anni che facciamo la scorta a Genovese, tutte le volte la stessa storia! Alle sette ordina il pollo fritto, alle otto arriva la buttana, alle otto e cinque siamo tutti in macchina. [Jack fiata] Al, ascoltami bene... quando Genovese ordinerà 'sto pollo fritto, io e Johnny gli prepareremo una sorpresa che quello se la ricorda per tutta la vita! Scenderemo in cucina e con una scusa distrarremo il cameriere, al posto del pollo ci facciamo trovare una bella pistola! È un gioco da ragazzi, no?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 93,
                column: "Content",
                value: @"Jack [rivolto a Johnny, fermatosi in mezzo alla strada in macchina]: Che succede, Johnny? Perché ci siamo fermati?
John: Ho bisogno... di riflettere, Jack! 
Jack: E su che minchia devi riflettere?
John: È finita la benzina!
Jack: E facciamola!
John: La benzina non si fa Jack, la benzina si compra!
Jack: E prendiamo i soldi e la andiamo a comperare! 
John: Quali soldi, Jack?
Jack: Perché, i soldi del Boss e dello smemorato [Al] te li sei già bevuti? 
John: IO!? [Tirando fuori un portagioie in oro] Se tu non ti compravi questo portagioie di Luigi XVI, avremmo ancora un po' di soldi!! 
Jack: Johnny, secondo te dove le ficco le anfetamine, eh? È colpa mia se sono un uomo con un certo gusto, che ha un certo savoir-faire? E comunque Johnny, tu te ne devi stare proprio zitto, sai? C'era bisogno di comprarsi un orso polare da mettere sopra il volante [Indica il volante ricoperto di pelliccia]? 
John: Ma che dici, Jack? Questa è tutta immagine! Serve per lavorare! Che ne sai tu? Che ne sai? 
Jack: Si comunque Johnny, non litighiamo per queste cagate. Ti ricordi che cosa diceva nostro padre? ""I soldi sono fatti per essere scialacquati. E quindi, boys, scialacquate! Scialacqua!""
John: Jack, non abbiamo mai avuto un padre...
Jack: Però sarebbe stato bello ricevere un'educazione così, vero Johnny?
John: [annuisce] Sarebbe stato bello...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 94,
                column: "Content",
                value: @"Aldo: Buongiorno! Dove andiamo di bello? 
Passeggero: Piazza Wagner. 
Aldo: Wagner, complimenti! Wagner! Il grande e irreprensibile Wagner! Compositore austriaco recentemente scomparso, autore del Lohengrin, opera che più o meno fa così... [inizia a intonare una melodia] 
Passeggero: Senta... A parte che è il Bolero di Ravel, e poi ho una certa fretta: piazza Wagner, al 27. 
Aldo: Ah! Questo è il Bolero?! Questo è il Bolero?! Vabbe'... Un attimo che impostiamo il navigatore, perché un conto è chi è Wagner e un conto è dov'è Wagner! ... Wagner si scrive con la G di Goethe?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 95,
                column: "Content",
                value: @"Claudia: Senti, ma perché stasera non andiamo a mangiare fuori? Una cosa semplice eh, una pizza. 
Giovanni [guardando Passaparola in TV]: Eh... Si boh... Dopo vediamo. Passaparola! 
Claudia: Magari un cinemino! È tanto che non ci andiamo! 
Giovanni: Sì... Magari... Mi son già tolto le scarpe... 
Claudia: O sennò restiamo anche a casa... 
Giovanni: Eh! 
Claudia: Tranquilli... 
Giovanni: Ma sì... 
Claudia: Ma sì, infatti, stiamo a casa. 
Giovanni [contento]: Dai!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 96,
                column: "Content",
                value: @"Claudia: Ma scusa, non guardi Passaparola? C'è la ruota finale... [Giovanni la interrompe] 
Giovanni: Ma chi se ne frega di Passaparola! Lo sto registrando!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 97,
                column: "Content",
                value: @"Giovanni [dopo che Claudia chiude una chiamata]: Chi cazzo era a quest'ora? 
Claudia: Che ne so, uno che ha sbagliato. 
Giovanni: Uno che ha sbagliato alle due di notte? 
Claudia: Giovanni, non è che dopo le due di notte non si può sbagliare... 
Giovanni: Sì ma io voglio sapere chi ha sbagliato...
Claudia [perde la pazienza]: Senti: è tardi, sono stanca e non ne voglio parlare! Lasciami dormire. Buonanotte.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 98,
                column: "Content",
                value: @"Claudia: Ma ti rendi conto che [si riferisce a Giovanni] è stronzo!? Io mi spacco la testa per cercare di salvare 'sto cazzo di matrimonio e lui cosa fa??? Che pezzo di merda...
Luciana: E tutte le belle cazzate che avete fatto ultimamente, anche quelle per salvare il matrimonio? Claudia, sono mesi che dici che sei stanca, che dici che sei confusa, che lo vuoi lasciare...
Claudia [inizia a piangere]: Allora vuol dire che deve finire così... [si asciuga una lacrima con la mano]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 99,
                column: "Content",
                value: @"Giovanni: E allora sai cosa faccio? Adesso vado lì, e a questa domanda deve rispondere: o lui o me. Capito? 
Giacomo: A parte che tecnicamente non sarebbe una domanda... Comunque, ho capito.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 100,
                column: "Content",
                value: @"Aldo: Allora com'è andata ieri notte?
Giovanni: Mah, niente.
Aldo: È andata male?
Giovanni: Ma no, il discorso non è andata bene o andata male...
Aldo: Insomma, dovete ancora... discutere?
Giovanni: Ma no, il discorso non è discutere...
Aldo [perde la pazienza]: 'Mariiia, mi stai facendo venire l'herpes! Che cosa vi siete detti? Che è successo???
Giovanni: Se n'è andata, è finita!
Aldo [prima esulta e Giovanni lo squadra di colpo]: No, niente. Mi è arrivato un SMS che aspettavo...
Giovanni: Solo che adesso cosa faccio, eh? Cosa faccio?
Aldo: Ma sì! Ma che vuoi fare? È la vita, dai! Oggi a te e domani a me, la cosa gira. Felice tu, felice un altro.
Giovanni [sarcastico]: Grazie! Sto già meglio!
Aldo: Mi sono spiegato male... E adesso lei dov'è?
Giovanni: Eh... Eh, dov'è... Lo so io dov'è: è insieme a quel bastardo, ecco dov'è!
Aldo [si preoccupa]: Quale bastardo?
Giovanni: Ma perché, non ti ha detto niente il tuo amico?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 101,
                column: "Content",
                value: @"Navigatore: Percorrere questa strada per settecentonovantanove chilometri. [passa un minuto] Percorrere questa strada per settecentonovantotto chilometri.
Giacomo: Ma questo navigatore è proprio indispensabile? 
Aldo: Metti che poi sbagliamo strada. 
Giovanni: Ma siamo in autostrada, è sempre dritto! Come cazzo fai a sbagliar strada? 
Aldo: Vabbe', non lo so spegnere, contento?! Lo so accendere ma non lo so spegnere. Si spegne solo quando si arriva, è concepito così! Qualche problema?! 
Giacomo [sarcastico]: ...Che bel clima. 
Giovanni: Che poi voglio proprio vedere... Me lo deve dire in faccia che il nostro matrimonio è finito per colpa [indicando Aldo] di un tassista terrone e dislessico! 
Aldo: Ti comunico che il terrone apoplettico... 
Giovanni: Dislessico! 
Aldo: Mmmmhhh, come preferisci! Comunque il suddetto terrone dislessico, in due mesi di frequentazione è riuscito a ridargli una voglia di vivere, a Claudia, che tu nemmeno se vivrai con lei diciotto secoli riuscirai a darle, va bene? E comunque se te lo vuoi sentir dire in faccia quanto sei noioso, tra settecentonovantotto km sarai servito. 
Navigatore: Percorrere questa strada per settecentonovantasette chilometri. 
Aldo: Novantasette! 
Giovanni: Che poi io, al limite, una sbandata per un tamarro come te sono anche disposto a capirla. Son quelle cose nella vita che devi fare per forza... Che poi però riponi nel cassetto ""cazzate dell'esistenza"", dove tu abiti tra l'altro. Ed è finita lì... Ma con questo qui dietro [indicando Giacomo]... Ma cosa cazzo mai ci avrà trovato? Cosa ci avrà visto in questo qua? Mi è inconcepibile! Non riesco a capirlo proprio! È una cosa al di là! Que... Cioè... ""Onde del destino""... Ma vai a cagare... 
Giacomo: Forse perché io riuscivo a farla parlare, eh? Perché se non te ne sei mai accorto caro mio, le donne han bisogno di parlare... Ma non solo loro, è proprio l'essere umano in se stesso è fatto di linguaggio, se non c'è la parola, tra gli esseri umani, la comunicazione, cioè è... [vedendo che Aldo al suo discorso sbadiglia] E vabbe'... 
Aldo: Bravo Giacomino, bravo! Parla, parla! Ma dopo tutto quel gran parlare, una donna deve estrinsecare la sua femminilità selvaggia... E allora... 
Giovanni: E allora cosa? 
Aldo: E allora... 
Giovanni: Hai detto allora, e allora cosa? 
Aldo: Quando una donna... 
Giovanni: No, non mi interessa quando, mi interessa allora! Hai lasciato allora coi puntini, riempili! 
Aldo: Giovanni, non è che posso riempirli tutti io i puntini. Penso di averne già riempiti abbastanza... 
Giacomo: Se posso dire... [Giovanni lo interrompe furioso] 
Giovanni [gridando]: Stai zitto! Tu devi stare zitto! Punto!
Aldo: Vuoi che ti riempia anche quello? Di puntino?
[Passa qualche ora e si fa notte]
Navigatore: Percorrere questa strada per 455 chilometri.
Giovanni [vedendo Aldo con gli abbiocchi]: Ohi! Ohi! Ohi! Vuoi che guidi io?
Aldo: Piuttosto che far guidare a un altro mi ammazzo.
Giovanni: Allora se magari prima mi fai scendere...
Aldo: Vabbè... Visto che non c'è il fisico ci fermiamo a dormire.Conosco un posto qui vicino.
Giovanni[vede ancora Aldo con gli abbiocchi]: Ma allora! [più tardi vede che si fermano in mezzo alla strada] Ma sei scemo? Ma spiegami perché non possiamo andare in un albergo! 
Aldo: Regola numero quattro: il taxi non si abbandona mai, cascasse il mondo, piuttosto mi faccio ammazzare a testate! E comunque, se vuoi un alberghetto usi le tue gambette da rannocchietto gracile e cammini, va bene?
Giacomo: Già ben capito come va a finire: si pernotta in un albergo a quattro stelle, servizio in camera... e anche la compagnia non è male, va. [a Giovanni] Dai ciccio, datti da fare!
Giovanni[ad Aldo]: E tra l'altro, questa macchina di merda qua ma chi vuoi che te la ciuli? 
Aldo: Dicevi così anche di tua moglie.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 102,
                column: "Content",
                value: @"Navigatore: Tra cinquecento metri svoltare a destra. Tra quattrocento metri svolt...
Aldo [dopo averlo preso a pugni]: Taci, zoccola! [a Giovanni] Complimenti per la scelta della casa, eh? Comoda! Sono due anni che siamo in giro e mancano ancora seimila chilometri. E poi come fai ad esser così sicuro che Claudia è al mare?
Giovanni: Ha preso le chiavi.
Aldo: Magari erano le chiavi del solaio.
Giacomo: Eh beh sì, magari è lì in solaio che riflette.
Giovanni: Ma no, è impossibile: non ce l'abbiamo il solaio. [Aldo lo squadra] Cioè: ce l'abbiamo, però le chiavi ce le ha il vecchio inquilino e quindi... [Aldo lo squadra di nuovo] Oddio... Adesso mi fate venire un dubbio...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 103,
                column: "Content",
                value: @"Giovanni: Sì ma quando cacchio arriva 'sto carro attrezzi?
Giacomo: Eh, devi star calmo però: dopotutto son passate solo... tre ore.
Giovanni [sente il motore del carro attrezzi]: Oahhh!
Vanni Maceria: Su di noi | l'amore è una favola...
Giovanni: Sì, però...
Vanni Maceria: Su di noi | se tu vuoi volare | ti porto lontano | nei campi di grano | a fare l'amore con me.
Giovanni: Ho capito, però sono anche...
Vanni Maceria: Tu dimmi ti amo | e vieni nel grano | nel prato più bello che c'è... Pupo! Pupone! La più grande rocchestarre italiana di tutti i tempi! L'eroe di Ponticino, deh!
Giovanni: Si ho capito, ma son tre ore e mezza che la stiamo aspettando!
Vanni Maceria: Oh scusate eh, bimbi... è alta stagione esagerata! È già un miracolo che sia arrivato qui io!
Giacomo: Botta di culo, eh?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 104,
                column: "Content",
                value: @"Vanni Maceria: Bimbi, c'ho una bella notizia per voi: avete spappolato il carburatore! È tutto ""sgarganato""!
Aldo: Che ha detto?
Giacomo: Carburatore.
Aldo: Ha detto carburatore?
Giovanni e Giacomo: Carburatore, carburatore.
Aldo: Carburatore proprio? Le parole erano queste? [si preoccupa] Ma no! Il carburatore no! E gli volevo bene come un figlio!
Vanni Maceria: Ma per te è Natale con le palle! Perché in mezzo alle palle ci sono io, il regalo: Vanni Maceria, il Brunelleschi dei Carburatori!
Giovanni: Però è simpatico.
Aldo: Senta, signor Brunelleschi dei Carburatori, e quando sarebbe pronta la macchina?
Vanni Maceria: Ar tocco è tutta pronta a modino.
Aldo e Giovanni: Oh, grazie signor Maceria.
Giacomo: Ma che cazzo avete capito? Vuol dire che è pronta domani all'una!
Giovanni: Eh, no... Dottor Maceria, non possiamo aspettare il tocco a modino.
Vanni Maceria: Oh, [indica l'orologio] è alta stagione esagerata! Ma lo sapete come si dice dalle mie parti? «Chi per la fretta caca nell'ortica, spesso il culo gli formica!» [proverbio]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 105,
                column: "Content",
                value: @"Aldo [preoccupato]: Che ci faccio qui? Che ci faccio qui?? Che ci faccio qui? Che ci faccio qui, Giacomino?
Giacomo: Ascolta, adesso tu bevi questo bicchiere d'acqua e vedrai che ti rassereni, vai. [Aldo lo beve] Va'... Oah! Hai visto? [Aldo butta dietro il bicchiere riducendolo in mille pezzi] Il bicchiere... Il bicchiere, del servizio buono!
Aldo [perde la pazienza]: Che me ne frega a me del tuo servizio di cristallo di Boemia, Giacomino, non fare il piccolo borghese! Sto impazzendo! Ho anche buttato il telefono nel naviglio... [inizia a piangere] Chissà quante volte m'ha chiamato e non m'ha trovato...
Giacomo [cerca di consolarlo]: Stai calmo. Stai calmo. Adesso ripeti tutto, magari in italiano e senza piangere. Allora: eravate al fast food tu e Claudia...
Aldo [cerca di smettere di piangere]: Eravamo al fast food io e Claudia... [si rilassa] Avevamo appena finito di fare l'amore. E tu, Giacomino, mi insegni che dopo aver fatto l'amore niente è meglio di un Big Mac...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 106,
                column: "Content",
                value: @"Aldo: Ah! Quasi dimenticavo... per la corsa sarebbero tremilaseicento euro.
Giacomo [strabuzza di colpo gli occhi e lo squadra]: Come tremilaseicento euro?!?
Aldo: Ah, gia: cappuccio e brioche... Quelli li offro io... Che vuoi? Sono fatto così. Chiamami scemo... chiamami ""unplugged"", ma sono fatto così...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 107,
                column: "Content",
                value: @"Aldo: [parlando via radio] Primo ufficiale Enterprise, abbiamo informazioni rilevanti dal pianeta sconosciuto. 
Giacomo: L'aria è respirabile, ma i livelli di monossido di carbonio sono sopra i livelli di guardia! 
Aldo: Beh?! Sono io che devo comunicare con Enterprise! Ti ricordo che tu sei solo un robot, uno stupido robot! Mentre io sono un umanoide! Li vedi i gradi? Ti ho progettato io! Sono ingegnere positronico laureato al Cepu!
Giacomo: Sette anni fuori corso!
Aldo: Ma che cavolo di umorismo ti ho impiantato? Guarda che posso spegnerti quando voglio, hai capito? Se solo mi ricordassi dove gli ho messo l'interruttore... [via radio] L'aria è respirabile, anche se... 
Giacomo: Inoltre abbiamo rilevato tracce di acqua, muschi, licheni e batteri, questo significa che siamo in presenza di forme di vita! 
Aldo: Ah, sì, bene! Bravo! Ora sta' a vedere che la creatura è più intelligente del creatore! 
Giacomo: Talvolta! In questo caso è certo! 
Aldo: Guarda che ti smonto e ti rimonto a immagine e somiglianza di un frullatore! E adesso che ti guardo bene, ci guadagni!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 108,
                column: "Content",
                value: @"Aldo: [via radio] Rientriamo alla base per analizzare meglio i dati. Testa di latta [A Giacomo], mettiti qua. [via radio] Mandate pure il raggio teletrasportatore. [Il raggio appare in una posizione sbagliata, alla loro destra.]
Giacomo: Ha progettato lei anche quello?
Aldo: [via radio] Avete sbagliato di poco, ma avete sbagliato! Rimandate il raggio... [Il raggio si sposta ma finisce ancora in un posto sbagliato, questa volta alla loro sinistra.]
Giacomo: Ci dev'essere suo fratello gemello al puntatore.
Aldo: Non è che per caso hai sbagliato tu le coordinate?
Giacomo: Di sicuro la cacata l'ha fatta lui.
Aldo: Aaaah, ma perché parla tanto? [via radio] Avete sbagliato di nuovo ma lasciate il raggio lì dov'è, che ci saltiamo dentro noi... sennò facciamo notte, in inglese fahrenheit!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 109,
                column: "Content",
                value: @"[Giovanni entra in scena affaticato spingendo un'enorme palla, la biosfera] 
Giovanni: [Col fiatone] Sembravo uno stercorario con la pallina, sembravo... 
Aldo: Comandante, ma come mai non è dentro la biosfera? 
Giovanni: Perché l'aria è irrespirabile dentro la mia biosfera! Chi è entrato per ultimo? Eh? Flander! [Giacomo alza le mani per provare la sua innocenza] 
Aldo: Comandante... sono entrato per fare meditazione dopo aver mangiato cavoletti di Bruxelles geneticamente modificati. Mi perdoni... 
Giovanni: Ho avuto un mezzo ictus lì dentro! Se non mi facevo una pera di eroi... di Roiptidanol ci lasciavo le penne!! 
Aldo: Comandante, sono molto costernato... 
Giovanni: Eh, sono costernato, non basta dire sono costernato! Ci vuole una manifestazione concreta di costernazione! [Aldo cerca di essere più dispiaciuto possibile, facendo una faccia triste] Da domani solo riso in bianco, eh? Almeno per un mese! [A Giacomo] Flander, porti al macero la mia biosfera. Purtroppo è irrecuperabile. 
Giacomo: Sarà un piacere prendere a calci questa palla di merda! [Prende a calci la palla di biosfera dietro le quinte]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 110,
                column: "Content",
                value: @"Giovanni: Primo ufficiale, com'è questo pianeta? Ditemi. 
Aldo: Comandante, questo pianeta è inutile e parsimonioso. 
Giacomo: Invece secondo me ci sono interessanti forme di vita che andrebbero analizzate! 
Giovanni: Ma sì, ma la vita l'abbiam trovata dappertutto, muschi, licheni, ragnetti, bruchi, vermini, quelle robe lì fastidiose... 
Aldo: Organismi monocellulari, brodo primordiale... e anche se si evolgono più in là della muffetta non vanno...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 111,
                column: "Content",
                value: @"Giacomo: [Il robot ha detto di aver individuato, tramite il rilevatore puntato verso il pubblico, che le forme vitali presenti sul pianeta si stanno muovendo] Comandante, non si allarmi, non sono ostili! Sono solo molto curiosi!
Giovanni: Ma... c'è dell'intelligenza?
Giacomo: Adesso non esageriamo, comandante! [Puntando il rilevatore verso il pubblico e spostandolo continuamente.] Tracce di intelligenza! Sì... un po' di più... molto meno... no... così così... potrebbe dare di più ma non si impegna... [Lo punta verso Aldo] È scomparso il segnale!
Giovanni: Eh per forza, lo sta puntando verso il primo ufficiale! Non è che possiam pretendere!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 112,
                column: "Content",
                value: @"Giacomo: Comandante, tenterei di stabilire un contatto con queste forme aliene. Potrebbero darci una mano a risalire sull'Enterprise. 
Giovanni: Ci penso io! Mostrerò loro il nostro elevatissimo grado di scienza, tecnologia e cultura! Li stupiremo! [al pubblico] Forme di vita semintelligenti, ditemi, l'uccellino è vivo o morto? Eh?
Irina [Con accento russo]: Eh, nel suo caso è morto, eh comandante!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 113,
                column: "Content",
                value: @"Giacomo: Comandante, muschi e licheni chiedono di parlare con l'interlocutore più qualificato.
Giovanni: Ci vorrebbe un volontario.
Aldo: Comandante, vorrei essere io il volontario.
Giovanni: Siamo spacciati.
Aldo: Comandante, le ricordo che io sono metà vesuviano e metà terrestre.
Giacomo: Avrei detto metà demente! 
Aldo: Ed ho insita in me la capacità di comunicare telepaticamente. 
Giovanni: Ma se deambula che è un miracolo, primo ufficiale!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 115,
                column: "Content",
                value: @"Giacomo: [Spazientito da Aldo che non riesce a prelevare dal bancomat.] Scusi, scusi, ha dei problemi alle mani? Tipo gravi impedimenti motori agli arti superiori? No, perché sono venticinque minuti che digita inutilmente su quella tastiera, suppongo nel vano tentativo di prelevare denaro senza riuscirci. Ce la farà entro Natale? Glielo auguro io e tutta la fila, grazie e buon lavoro!
Silvana: Va be', scusi eh! Stia tranquillo, ci sono prima io davanti, quindi...
Giacomo: Quindi se lei non ha un cazzo da fare è un'altra questione, ha capito? Non è che possiamo star qua tutta la mattina ad aspettare uno che deve fare un prelevamento!
Aldo: Per favore cortesemente, glielo dico cortesemente, eh? Può... andare un passo dietro la linea gialla? Eh? E non starci sopra? E non schiacciare la schiena alla linea gialla, eh? Perché la linea gialla soffre! Perché la linea gialla è un punto di, di, di fermo, non un punto di sovraccarico, ha capito? Non le sto chiedendo chissà che cosa! Voglio dire, è inutile che mi guarda con questi occhi da cernia! Forse perché mi vuole cernire il codice segreto? È per questo che va un passo avanti, eh? Questo... allunga questo collo a brontosauro perché mi vuole cernire il codice segreto? Eh? Eh? Cosa vive lei ancora nel giurassico signora? Guardi stiamo facendo una una cosa di di proprietà privata questa è una stanza non è un cantieeereeee! E non è quest e non mi guardi questa oassessa, uh, ah! 
Giacomo: Signora non faccia gli occhi da cernia e il collo da brontosauro con uno che ha dei problemi motori alle mani e soprattutto, ormai è acclarato, siamo di fronte a un individuo che non sa ne intendere e ne volere, capisce? Se no siamo qua fino alla prossima olimpiade. 
Silvana: Ma guardi che è diventato tutto rosso eh, prende le malattie, sa... Lei deve assorbire tutte le energie benefiche della luna, eh! Apra tutti i suoi chakra!
Giacomo: Glieli aprò io i chakra, adesso!
Aldo: No! Ho sbagliato! Ho sbagliato, è la seconda volta che sbaglio, ora se sbaglio anche la terza volta mi mangia la tessera del bancomat, io sono un uomo finito.
Giacomo. Magari così si leva dalle palle e preleviamo noi.
Aldo: Telefono a casa. 
Giacomo: Telefono a casa?
Aldo: Ma tanto è inutile non ci sarà nessuno adesso... 
Giacomo: Ma porca di quella...
Aldo: Graziella sei a casa? Mamma mia, mi stai salvando la vita, non sai quanto ti sono grato che tu sei a casa in questo momento, Graziella ascolta eee è Graziella, mia suocera, è a casa. 
Giacomo: [Sarcastico] Ce la saluti molto calorosamente. 
Aldo: Ti saluta... lei è?
Giacomo: Giorgio Stramaroni. 
Aldo: Giorgio Stramaroni una persona molto in. Ascolta Graziella dovresti andare in camera di Gaetano, hai presente capitan orsetto, quello che lui ci gioca sempre che parla sempre con lui che per parlare con me parla attraverso di lui, capitan orsetto quello che ci dorme tutte le notti... ce l'hai in mano? Squartalo! Dentro ci deve essere il numero di codice del bancomat! Tira via la paglia, l'hai trovato? Eh, dimmi... cinque, quattro... sette... No!! No, Graziella no! 5-4 è il numero di codice segreto per vedere i porno su Sky! [Guarda Giacomo, imbarazzato] Guardi che lo faccio di lavoro... cioè, che mi frega a me? 
Giacomo: E che lavoro fa?
Aldo: Falegname.... allora Graziella vai in camera di Caterina, [Di nuovo, a Giacomo] Caterina è mia figlia, la femmina. Mamma mia quanto è grande. 
Giacomo: Scusi, quanti figli ha?
Aldo: Sette! 
Giacomo: [A Silvana, sapendo come andrà a finire] Stiamo qua fino alla prossima Olimpiade, glielo dico io... 
Aldo: Allora Graziella, sei in camera di Caterina? Ok allora, davanti all'armadio c'è la sua collezione di Barbie, ok, prendi ""Barbie Baldracca""... Non quella con le calze a rete rotte, quella è ""Barbie Alcolista"", ""Barbie Baldracca"" è quella con la minigonna vertiginosa, c'ha il tatuaggio della farfalla sul gluteo, e sotto l'ombelico c'è il codice... l'hai trovato? Dimmi! 1, 2, Vai piano che non ti seguo... 2 me lo metto qua... 3 me lo metto qui... [indicando varie zone della testa] 
Giacomo: Scommetto che è 4 e 5. 
Aldo: 4 me lo metto qui e 5 me lo metto qua sotto il cervelletto. Ciao, vado se no mi dimentico i numeri, ciao! 
Giacomo: [A Silvana, dopo aver scoperto il codice, ovvero 12345, considerando il tempo che Aldo ha perso per indovinarlo] Una famiglia di geni!! I più famosi criptologi dell'Altitalia!! Che cazzo parlo a fare con lei... 
Aldo: [Comincia a tastarsi i punti della testa dove ha ""salvato"" i numeri, ma li digita lentamente] Allora, il primo è... 1... e poi... 2, 2... [Si sforza, tastandosi la testa] Mii! E l'altro numero dove l'ho messo? L'ho già perso... 
Giacomo: [A gran voce, per incitarlo a muoversi] Minchia... 3!!! Provi col 4, e tentiamo il 5! 
Silvana: Ma scusi lei, eh, ma come faceva a saperlo?
Giacomo: [Sarcastico] Piacere, mago Merlino! 
Silvana: Ma va? 
Giacomo: Vuol vedere la bacchetta magica?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 116,
                column: "Content",
                value: @"Giovanni: Tipo, ce li hai dieci euro? Sai... per i cani... 
Giacomo: [Indicando il bancomat.] Appena riesco a prelevare! 
Giovanni: Grazie... Senti, vuoi che ti faccia un tatuaggio? [Ripete col megafono] Un tatuaggio?? 
Giacomo: No, grazie, fallo a tua sorella il tatuaggio! 
Giovanni: [Sempre col megafono] E un piercing??? 
Giacomo: [Minaccioso.] Se non ti levi ti faccio il clistere, capito?? [Giovanni brontola] 
Silvana: [Parlando dei cani di Giovanni.] Ma che belli che sono, eh? 
Giovanni: Eh sì, sono cani. 
Silvana: Sì, lo so! 
Giacomo: Perché non ne porta a casa due?
Silvana: Eh no, eh, perché non ho il giardino...
Giacomo: Che sfiga...
Giovanni: [Col megafono] Vuoi un roipnoil? Eh?
Silvana: Eh no, eh, perché non ho il giardino...
Giacomo: Ma voi due vi siete conosciuti a San Patrignano? Eh?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 117,
                column: "Content",
                value: @"Silvana: Senta lei, scusi se mi permetto, ma lo sa che non si danno calci ai cani?
Giacomo: Chiedo scusa, la prossima volta li darò a lei.
Silvana: Eh no, eh, perché non ho il giardino...
Giacomo: [Al pubblico] Adesso mi compro una dose di eroina e mi ammazzo! Qui la venderanno, eh... 
Silvana: [Parlando dei cani di Giovanni] Ma che belli... 
Giovanni: [Col megafono] Ti piacciono?? 
Silvana: Scusi, ma io ci sento, eh! 
Giovanni: Brava! 
Giacomo: Una cosa che funziona lì dentro... 
Silvana: Eh no, eh, perché non ho il giardino... 
Giacomo: Che cazzo sarà? Le polveri sottili... cosa sarà?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 120,
                column: "Content",
                value: @"Aldo: Oh, dovreste farmi tutti un favore! Scusate, lì dietro... Allora, dovremmo fare tutti una cosa insieme. Siccome qui c'è una gazza ladra addestrata a portare via i soldi al malcapitato... ed è capitato. Allora, per evitare che questa qui plana, agitiamo tutti le mani, così questa qui si spaventa e non plana. Avanti, facciamolo, dai! Forza, tutti insieme. Agitiamo le mani. [Silvana e Giovanni lo fanno, mentre Giacomo sta con le braccia incrociate.]
Silvana: Senta, scusi, ma agiti le braccia, che cosa le costa?
Giacomo: [Le agita con malavoglia] Tanto la mattina è andata a puttane!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 121,
                column: "Content",
                value: @"Silvana: [Aldo ha finalmente finito di prelevare e Giacomo passa davanti al bancomat.] Scusi eh, forse non si ricorda, ma c'ero prima io davanti a lei!
Giacomo: Ha ragione, ma... incameri l'energia di Nettuno e Plutone, faccia un soffritto ayurvedico, liberi due o tre chakra e si tolga dalle palle! Va bene?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 122,
                column: "Content",
                value: @"[Giovanni e Giacomo parlano dietro le quinte, mentre Aldo compare in scena e osserva un quadro] 
Giacomo: Allora Giovanni, appena entri in questo museo, ti accoglie subito un capolavoro. 
Giovanni: Questo qua? 
Giacomo: Questo è un quadro di Braque... 
Giovanni: Braque? 
Giacomo: Siamo agli inizi del secolo scorso... ah, una particolarità: questo quadro va visto da lontano... [Aldo indietreggia] 
Giovanni: Ma dai? 
Giacomo: Sì si... no, ma non così, veramente lontano. Vai, allontanati! [Aldo si allontana] 
Giovanni: Ancora di più? 
Giacomo: Perché l'artista ha lavorato sulle linee, sulle forme e sui volumi, creando una specie d'illusione ottica... e vuole che tu stia veramente lontano! Vai, vai, arretra! [Aldo si allontana ancora di più] 
Giovanni: Va bene, arretro! 
Giacomo: Quando sei nella giusta posizione, che fai? Apri e chiudi gli occhi fino a quando l'essenza del quadro stesso non ti compare dentro la pupilla, come se fosse un flash, una sorpresa! 
Giovanni: Ah, una sorpresa! [Aldo comincia ad aprire e chiudere gli occhi, facendolo nei modi più bizzarri] 
Giacomo: E questo è un po' ciò che sta alla base del Cubismo... perché questo è un quadro cubista. Poi, l'altra particolarità è che l'artista ha lavorato pressoché con un colore solo, quindi...? 
Giovanni: È monocromatico! 
Giacomo: Bravo! Stai imparando le parole dell'arte! Quindi Cubismo e Monocromatismo. L'artista è Braque, il quale, insieme a Picasso, all'inizio del secolo scorso, ha aperto tutte le porte all'arte moderna che da lì in poi... si sarebbe succeduta... [Lui e Giovanni entrano in scena ed osservano il quadro che stava guardando Aldo] 
Giovanni: Ma và? 
Giacomo: Oh, qui ci troviamo di fronte a tutt'altro stile pittorico. C'è da dire una cosa in maniera preliminare, che questo quadro va visto...? 
Giovanni: Beh, da vicino! 
Giacomo: Perché soltanto un cretino si allontanerebbe per vedere questo quadro! [Aldo si riavvicina al quadro] E questo è un quadro che va visto nella sua giusta distanza... ecco, qual è la prima cosa che ti viene in mente, osservando questo quadro? 
Aldo: Che è monocromatico...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 123,
                column: "Content",
                value: @"Giacomo: [Vedendo Giovanni sedersi su una sedia] Ma sei scemo Giovanni? Sei cretino? Hai rovinato una scultura di Fistalloni!
Giovanni: Non lo sapevo! [Rivolto ad Aldo, scandalizzatosi] Ma se non sai neanche chi è!
Giacomo: Ma scusa, ma questo è il maestro del distrutturalismo!
Giovanni: Eh, mia nonna ne ha a casa due uguali, pensavo che fosse...
Giacomo: Ma Giovanni! Ma questa non è una sedia comune!
Giovanni: No?
Giacomo: Questo è il concetto di sedialità, che il maestro Fistalloni ha voluto rappresentare estrapolando una sedia dal contesto abituale in cui solitamente sta, in una misera cucina, ed elevandola ad universale! Fistalloni!
Aldo: Fistalloni! Eh, ti sei seduto sul concetto di Fistalloni!
Giovanni: A parte che Fistalloni pensavo fosse uno della Lega...
Aldo: Ma che Lega! Fistalloni, insieme a Jocelyn, Gogard... la – la – la corrente del ""distrullarismo""!
Giovanni: Sì, la corrente alternata...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 124,
                column: "Content",
                value: @"Giovanni: Cioè quella lì non è una sedia, e questo è un estintore?
Giacomo: Mi stupisco che tu non colga la differenza tra oggetto e sua rappresentazione, tra realtà e opera d'arte, tra immanenza e trascendenza. Ci sono voluti secoli di dibattito metafisico e ontologico attorno al concetto di rappresentabilità che l'uomo oramai ha introiettato, e superato. Perdonami caro.
Giovanni: Ma vaffanculo! [Tirando un calcio all'estintore vero che credeva essere la rappresentazione di un estintore]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 125,
                column: "Content",
                value: @"Giacomo: Venite... Venite qua... Mettetevi di fianco a questo quadro, che è considerato il capolavoro del museo. Osservatelo bene, dopodiché: che cosa ne dite?
Giovanni: Eh, che qualche deficiente l'ha rovinato con un taglierino! Si vede, porca va... Ha fatto tre sbreghi... È chiaro, non c'è controllo.
Aldo: Poi m'indigno, ci sarà un motivo perché mi indigno? Fanno entrare chiunque, si riempiono le tasche di taglierini, fanno quello che vogliono e noi non facciamo niente.
Giacomo: Posso urlare al mondo la mia indignazione? Posso farlo? Quanta ignoranza!
Giovanni: Bravo! Quanta ignoranza ci vuole per fare una roba del genere, dai! Un minimo di testa...
Aldo: Ma io non capisco... se tu sei ignorante, rimani nella tua ignoranza, rimani nella tua mediocrità! Ma invece sei invidioso, geloso, e vieni qua dove ci sono persone che comunque si vogliono evolgere...
Giovanni: Da che lato? A destra o a sinistra si vogliono evolgere?
Giacomo: Ma ditemi dove sbaglio? Ditemi dove sbaglio! E cosa posso fare!
Giovanni: Ma niente Giacomo, ma tu anzi, cavolo, tu sei bravissimo, sai un sacco di cose, le spieghi... avercene!
Aldo: Ma... Giacomino, esistono i cretini... esistono, giusto? Purtroppo sì, e sono anche molto vicini a noi.
Giacomo: Molto più di quanto non si creda!
Aldo: Più di quanto non si creda, bravo. Tu non ti sottovalutare mai, perché tu sei un diadema di questa società. È grazie a te che il mondo va avanti. È grazie a te che io oggi so qualcosa!
Giovanni: Niente, però questo è un altro discorso.
Giacomo: Ditemi almeno chi l'ha fatto.
Giovanni: Eh, saperlo, vedi che calci nel culo gli davamo, se lo beccavamo mentre lo faceva! 
Aldo: Mica è la prima volta che prendiamo a calci nel culo... 
Giovanni: Oh, abbiamo beccato una volta uno che rigava una macchina. Lui l'ha preso al volo, io da dietro pam, pam!
Aldo: Tre isolati a calci nel culo, prova a chiedergli a quello lì se ha ancora intenzione di rigar le macchine! Non lo fa più! Perché queste cose servono! Ogni tanto servono! Non sempre, però servono.
Giacomo: Lucio Fontana.
Giovanni: Ah, si sa chi è! Ah, l'han beccato. Ah bè meno male, almeno uno, una volta...
Aldo: Allora la giustizia funziona! Dieci anni, gli devono dare. Prendere uno, per prenderne cento. Cioè prenderne uno, prenderne cento. Prenderne uno, per prendere cento. Cioè, voglio dire, ci sono questi cento che camminano a stormo, adesso... voglio dire... fra cretini si ritrovano e camminano tutti così, tutti a stormo così... come, ogni tanto, come gli stormi, proprio... che si allargano, si stringono, camminando. E danno anche fastidio da vedere. Poi c'è qualcuno che è al centro dello stormo, non riesce a respirare, ha bisogno di aria, allora si fa strada fino a che arriva nella zona limitrofa dello stormo e spinge quello che è già lì. Questo qui si perde dal gruppo e viene preso. Quindi prenderne uno, per non prenderne novantanove!
Giovanni: Non credo che fosse così, però...
Giacomo: È nato nel 1906 [In realtà il vero anno di nascita è il 1899] .
Giovanni: Un vecchio! Eccolo lì! Ma porca vacca! Ma lasciali lì a guardare gli scavi in strada, che son contenti! Stan lì: ""E va la ruspa, che la tira su la roba! Li tubi che van lì"" e lì passano il tempo e son contenti. Ma perché li devi far venire qui che non c'han più la testa.
Aldo: Ma io non lo so, se tu sei un vecchio perché sei un tenero, hai bisogno di... No, voglio dire, se tu sei stato un cretino da bambino, sarai un cretino anche da vecchio!
Giovanni: Eh, non indicare però...
Aldo: Se tu nasci torto, Giacomino, muori torto! Se tu nasci dritto... non è detto che muori dritto... puoi anche morire torto. Secondo le... Ma se nasci torto non puoi morire dritto! E non lo dico io, lo dice un greco... Lapalissian, un greco... ma, del, proprio della Grecia.
Giacomo: È nato a Rosario, in Argentina.
Giovanni: Un extra-comunitario! Ma porca vacca! Ma tu li accogli qua e loro se ne fregano delle regole. Non gli interessa nie... A casa loro fai una roba del genere? Ti taglian la mani e vai in giro così! E invece qua puoi far quello che vuoi, perché? Perché nessuno rispetta più le regole, è chiaro.
Aldo: Ma non solo! Perché glielo si lascia fare! Vedi, noi siamo stati immigrati a nostra volta, ma quando siamo andati a casa di queste persone ci siamo comportati in ben altro modo, e abbiamo fatto delle offerte che non potevano rifiutare.
Giacomo: È morto nel 1968. Dopo aver regalato al nostro paese capolavori di inestimabile bellezza esposti nei musei più importanti del mondo, dopo aver inventato lo spazialismo e i famosissimi tagli nelle tele. E voi due siete due bestie. [Ad Aldo.] Tu poi, sei nato torto e morirai testa di cazzo!
Giovanni: È un'aggravante, eh.
Aldo: Tu devi stare solo zitto, perché ti sei seduto anche sul concetto di Fistalloni!
Giovanni: Ma se hai guardato un quadro normale da 3 chilometri?
Aldo: Ha parlato quello che non sbaglia mai... mi fai una rabbia, guarda...
Giovanni: Sì, ma... [Per allacciarsi una scarpa, schiaccia accidentalmente uno sgabello]
Aldo: [Sottovoce] Lo vedi che sei un cretino? Questa è la dimostrazione che sei un cretino! [Giovanni toglie il piede, e lo sgabello rimbalza all'improvviso. Aldo fa in tempo a prenderlo al volo]
Giovanni: [Sottovoce] E' saltato! Hai visto? Saltato per aria... cos'era?
Aldo: Non cercare scuse!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 126,
                column: "Content",
                value: @"[Davanti a una cornice vuota, in cui Giovanni infila la mano]
Giacomo: Cosa tocchi? Cosa tocchi?!
Giovanni: Non c'è niente!
Giacomo: Ma come non c'è niente?!? [con enfasi] È un'opera d'arte...
Giovanni: L'han ciulata...?
Giacomo: Non l'hanno ciulata! Sei di fronte a un capolavoro... di Jean Fofon!
Giovanni: Ah, il francese!
Giacomo: Belga, bestia! Questo è il maestro del coinvolgismo: l'artista ha messo a disposizione il suo spazio vuoto perché vuole che sia tu, fruitore, a riempirlo.
Giovanni: Cioè lui non ha fatto un cazzo, ha detto ""tanto la gente poi ci vede quello che vuole"", e io me ne lavo le mani...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 127,
                column: "Content",
                value: @"[Davanti alla cornice vuota] 
Aldo: Ma questo va visto da vicino o da lontano?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 128,
                column: "Content",
                value: @"[Aldo si è incastrato in una statua, e prova ad attirare l'attenzione di Giovanni e Giacomo] 
Giacomo: Ehi! Vieni via di qua! Vieni via di qua!! Questa è una scultura? Questa è una scultura di Tanguely, vieni via di qua! [Gli schiaffeggia il libretto della guida in testa] 
Aldo: Ahia... 
Giacomo: Ma cosa fai qua dentro? 
Aldo: Eh, sono incastrato, non riesco ad uscire! 
Giacomo: Ma come cazzo fai ad incastrarti in una scultura? 
Aldo: [piangendo] Ma che ne so! Ero qui tranquillo, mi hanno spinto! 
Giacomo: Ma chi ti ha spinto? 
Aldo: Non lo so... ho sentito quattro... [Giacomo gli schiaffeggia il libretto di guida in testa] ahia! 
Giacomo: La tua idiozia ti ha spinto!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 129,
                column: "Content",
                value: @"Giacomo: [Su tutte le furie, riguardo ad Aldo, incastrato in una scultura] Guarda, ti ammazzerei di botte, ti ammazzerei! 
Aldo: [Fa per andarsene con la scultura, girando una ruota montata su di essa come volante] Vabbè, parcheggio e ci mettiamo d'accordo... 
Giacomo: Guarda che l'arte merita [Gli schiaffeggia ripetutamente il libretto di guida in testa] ri-spet-to! Hai capito? 
Aldo: Ma perché te la prendi con me, sono scivolato su una buccia di banana! 
Giovanni: Ma prima avevi detto che ti avevano spinto!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 130,
                column: "Content",
                value: @"Giovanni: Ma sei sce... Ma dove guardavi, hai fatto la puntura a me! 
Giacomo: Ma scusa, ti metti lì davanti! 
Giovanni: Ma non distingui il culo? 
Giacomo: Ma Giovanni, il culo è culo. 
Giovanni: E no, c'è culo e culo: pensa a Dolce e Gabbana!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 131,
                column: "Content",
                value: @"Aldo: Ha visto com'è stata veloce la funzione signora, sono diventato cardinale or ora. 
Signora: Perbacco. 
Aldo: Senta signora, purtroppo devo darle una brutta notizia... In casa sua, mi dispiace dirglielo si annida... nientepopodimeno che il Demonio! 
Signora: Cosa si annida? 
Aldo: Il Demonio si annida quasi sempre nel sifone... 
Signora: Nel sifone, il Demonio?! 
Aldo: Nel sifone sotto il lavandino. Oppure nel water nel caso lei non abbia tirato l'acqua, ma lei ha tirato l'acqua...? 
Signora: Io tiro sempre l'acqua! 
Aldo: Eh, allora è sicuramente nel sifone signora. Signora, parliamoci in maniera papale papale. Dovrebbe far entrare il mio adepto, che è un esorcista della curia di Milano e le stanerà dalla posizione sifonile il Demonio. 
Signora: Senta, ma il suo adepto mi ha appena depto che era qui per la benedizione natalizia. 
Aldo: A Pasqua? 
Signora: Eh! 
Aldo: Le ha detto una cacata. [La signora ha capito della truffa, e Aldo inizia a preoccuparsi]
Signora: Senta, vuole che le passi l'esorcista o l'idraulico? 
Aldo: Mi può passare tutt'e due per cortesia?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 132,
                column: "Content",
                value: @"Giovanni: [Mentre Aldo cerca di rubargli il motorino] Uè, Nino, cosa stai facendo? Uè! Vieni giù dalla moto! Allora! Porca vacca, stavi cercando di rubar la moto, eh? 
Aldo: Sono un collezionista. 
Giovanni: Eh, so io che cosa collezioni tu, va là!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 133,
                column: "Content",
                value: @"Giacomo: Allora, Mozambico? 
Aldo: Sono un collezionista. 
Giacomo: Cosa colleziona, avvisi di garanzia?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 134,
                column: "Content",
                value: @"Giacomo: Con questo lei cosa vorrebbe dire? Che ci sono cittadini di serie A e cittadini di serie B secondo lei?
Giovanni: Mah, se lo guardiamo bene in faccia, lì siamo C2 zona retrocessione!
Giacomo: Ahhh, un razzista!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 135,
                column: "Content",
                value: @"Aldo: Meno male che forse sono italiano! Sono di Gela.
Giovanni: Di Gela... ah di Gela! Ma dai, Gela, profondo sud, l'han chiamata Gela! Ma chiamala in Scandinavia Gela! Profondo sud chiamala Caloria, per dire... per dire la gente che c'è in quel posto lì... Lei mi insegna.. città di baluba sicuro!
Giacomo: Mia mamma è di Gela! 
Giovanni: Io faccio sempre due settimane di vacanze a Gela. 
Giacomo: Caro il mio bel furbino, a Gela non si fanno vacanze, a Gela si lavora e ci si rompe i coglioni, ha capito? 
Giovanni: Infatti un po' tutte e due mi ricordo. 
Giacomo: È sua questa moto? 
Giovanni: Ehm... sì, è mia! 
Giacomo: Questa moto in divieto di sosta è sua? Sono 140 € di contravvenzione! Perché certo il suo scarsissimo senso civico le suggerirà che i marciapiedi sono fatti per farci cagare i cani e dimenticare le moto in divieto di sosta. Complimenti! 140€ di contravvenzione 
Giovanni: No... ero impossibilitato... Ma guarda te!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 138,
                column: "Content",
                value: @"Giacomo: [Giovanni ha dato una lieve botta sulla spalla ad Aldo, che si accascia a terra dolorante] Madagascar! Allora! 
Aldo: Non ci vedo più! 
Giovanni: Ma gli ho dato un colpo qua, cosa c'ha il nervo ottico sulla spalla? 
Giacomo: Lo sa che ci sono delle ripercussioni gravissime?? 
Aldo: Ho preso anche il colpo di frusta!
Giovanni: Sì, ti porto al circo allora col colpo di frusta!
Aldo: Non vedo più niente! Vedo solo puntini! 
Giovanni: Ecco bravo uniscili i puntini, e viene fuori quello che sei: S-t-r-o-n-z-o [Indietreggia perché Giacomo si avvicina minaccioso] 
Giacomo: Guardi... lei si sta mettendo in una brutta situazione ha capito? Abbiamo fatto la revisione di questo motociclo?
Giovanni: Certo!
Giacomo: Eh, ""certo""! Non ne sarei così sicuro, non vedo il bollino blu!
Giovanni: Ma non è mica una banana!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 140,
                column: "Content",
                value: @"Giacomo: [Guarda inorridito le chiavi della moto di Giovanni] Non mi dica che queste...
Giovanni: Sì, son le palle del gatto... le ho fatte mummificare perché c'ero affezionato... Deve vedere il gatto, se le lecca ancora! Fa... [Imita il gatto] poi si accorge che non ci sono e fa una faccia tutta... sto pensando di riattaccargliele per dargli fiducia!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 141,
                column: "Content",
                value: @"Aldo: Ah, senti che aria pulita! Respira a pieni polmoni.
Giovanni: Che vista che c'è, eh! Siamo in alto.
Aldo: Altissimo, altroché.
Giovanni: Senti, ma... quello là è il Duomo di Milano?
Aldo: Pensa che l'aria è così pulita che quello è il Duomo di Pavia.
Giovanni: Ma dai! Quindi quella là dietro non è la montagnetta di San Siro?
Aldo: No, è l'Etna! 
Giovanni: L'Etna! Che tersitudine che c'è oggi!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 142,
                column: "Content",
                value: @"Giovanni: Trenta piani quanto sono in misura?
Aldo: Eh... trenta piani sono cento foot.
Giovanni: Cento foot? E cento foot quanto sono più o meno?
Aldo: Cento foot sono più o meno venti yard.
Giovanni: Venti yard. E in metri non si può misurare? 
Aldo: Se facevamo la staffetta 4x4, misuravamo in metri, siccome stiamo facendo jumping si misura in foot, massimo in yard!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 143,
                column: "Content",
                value: @"Giacomo: [Col fiatone] Ho fatto trenta piani a piedi... 
Giovanni: È dura, eh? 
Giacomo: È dura... porca troia se è dura! Ma perché non mettete l'ascensore? 
Giovanni: Eh, non sono l'amministratore di condominio! 
Giacomo: Ah, non sei tu l'amministratore...? Federico! [È l'unico nome con cui riconosce Giovanni] 
Giovanni: Giovanni! Devi stare a casa! 
Giacomo: Ho capito, ma a casa mi annoiavo... 
Giovanni: Ma c'era tutto quello che ti serviva! 
Giacomo: C'era tutto, ho finito il vino e son venuto via... 
Giovanni: Ma se ti ho lasciato tre bottiglioni! 
Giacomo: Tre bottiglioni in una giornata van via, eh! Eh, la noia è dura da combattere... Federico! 
Giovanni: Giovanni! [Ad Aldo, che si è scandalizzato della presenza di Peppino] Figa... schiuma come un lupo! Questo qua è il nonno che mi han dato in affido. 
Aldo: Nonno in affido? 
Giovanni: Eh sì, ho firmato a un banchetto, pensavo per le primarie, invece era per avere il nonno in affido. 
Aldo: Ma dà fastidio? Ci si può fidare o...? 
Giovanni: No... no... è bravo... mangia, beve come un lupo, scoreggia come una locomotiva... e... e poi cosa c'ha, c'ha una punta d'Alzheimer e un'altra malattia che non mi ricordo, boh... [Vede Peppino che si sporge dal palazzo] Nonno, attenzione, è pericoloso! Non c'é il parapetto! Son trenta piani! 
Giacomo: È bello profondo, eh! Porca troia, saran cento foot!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 144,
                column: "Content",
                value: @"Aldo: Peppino! Come la va la famiglia? [Peppino comincia a piangere] 
Giovanni: Ma se è in affido non ce l'ha la famiglia, no?! Ma sei deficiente?!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 145,
                column: "Content",
                value: @"Aldo: Peppino! Chissà quante ne hai da raccontare ai tuoi nipoti... [Peppino piange] 
Giovanni: Ma allora sei deficiente! Se non ha la famiglia, non ha i nipoti! Cambia argomento! Un altro argomento, dai! 
Aldo: [Abbraccia Peppino] Peppino! Non fare così ti prego! Scusami! Se vuoi... che squadra tieni?? [Peppino piange disperatamente] 
Giovanni: Ma tiene all'Inter! 
Aldo: E che ne so io!!!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 146,
                column: "Content",
                value: @"Giacomo: Eran quattro Fenici di merda che se li incontro... BAM! 
Aldo: [Ironico] Fenicità! No... dico... ""Fenicità"" cioè... è Napo-Napo-Napo-Napoletano... 
Giacomo: Ma le spieghi anche le cagate che dici?!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 147,
                column: "Content",
                value: @"Aldo: Ascoltami... quella è la capanna dello zio Tom. e qui, tra il Tigri e l'Eufrate devi stare attento che non entri nessuno. Se per caso entra qualcuno, chiedi la parola d'ordine... 
Giacomo: Password. 
Aldo: No, la decidiamo insieme, non è che devi decidere da solo. Per esempio ""La parola d'ordine..."" 
Giacomo: Password! 
Aldo: La parola d'ordine è... 
Giacomo: Password! 
Aldo: Ahh, ""vaffanculo""! La decido io, e basta, e che è, la deve decidere lui ? !");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 148,
                column: "Content",
                value: @"Aldo: [Preoccupato perché gli sembra che Peppino gli abbia infilato il tappino del bastone nel sedere toccandolo] Peppino... c'era il tappino prima nel bastone? 
Giacomo: Certamente! 
Aldo: Ho paura a chiederlo... e che fine ha fatto? 
Giacomo: Inside your body! 
Aldo: [Guarda Giovanni] Non so l'inglese, ma credo di aver capito... Se mi muovo con cautela non lo sento, ma se mi muovo shakerando lo sento...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 150,
                column: "Content",
                value: @"Aldo: [Giovanni si prepara a saltare giù, e Aldo fa il conto alla rovescia] Allora.. UNO... sgombra la mente... DUE... sgombra la mente... TRE... [Si ferma all'improvviso] EH OH! FERMATI!!! 
Giovanni: Cosa c'è?! 
Aldo: Santo Iddio! [Lega la corda a cui era fissato Giovanni] 
Giovanni: [Guarda Giacomo, scandalizzato] Ma non aveva messo la corda!? 
Giacomo: È un Ugonotto! Non fidarti! 
Giovanni: Ma che Ugonotto! [Ad Aldo] Ma non avevi messo la corda!? 
Aldo: E vabbé... non è successo niente! Perché mi guardi con quegli occhi? 
Giovanni: Eh... no, un miracolo è successo! 
Aldo: Appunto, avevamo bisogno di un miracolo, l'abbiamo avuto! 
Giovanni: Eh se ne abbiam bisogno due son spacciato! 
Aldo: Uno ce ne serviva!! 
Giovanni: Speriamo... ma poi l'hai mai fatto? 
Aldo: L'ho visto fare migliaia di volte! 
Giovanni: [A Giacomo, terrorizzato] L'ha visto fare, non l'ha mai fatto!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 151,
                column: "Content",
                value: @"Aldo: [Peppino non torna su e Aldo tira la corda a sé] È molle! 
Giovanni: È molle? 
Aldo: È leggero... 
Giovanni: Adesso quando arriva il messo cosa gli do io, il bambolotto!? 
Aldo: [Urla dopo aver tirato su la corda e aver visto legata ad essa solo una gamba di Peppino] AHH!! AHH!! AHH!! Ma che cosa abbiamo combinato?? 
Giovanni: [Guarda la gamba di Peppino e si ricorda] Ecco qual era l'altra malattia che non mi ricordavo! Osteoporosi!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 152,
                column: "Content",
                value: @"Moglie di Giovanni: Che fai, non saliamo?
Giovanni: Prima controllo le gomme!
Moglie di Giovanni: A quest'ora?!
Giovanni: Perché, c'è un'ora?
Moglie di Giovanni: Scusa, ma non le avevi controllate ieri quando sei andato a lavare la macchina dentro e fuori e hai fatto benzina?
Giovanni: Sì, ma non mi fido! Metti che stanotte l'umidità me le ha fatte scendere di 2 atmosfere!
Moglie di Giovanni: Mamma mia...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 153,
                column: "Content",
                value: @"Suocera di Aldo: Le gomme anteriori sono sgonfie, eh!
Aldo: Embé?
Suocera di Aldo: Embé, non è sicuro!
Aldo: Le ho sgonfiate apposta! Metti che passiamo sotto un cavalcavia troppo basso, che faccio, scendo e sgonfio le gomme?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 154,
                column: "Content",
                value: @"Suocera di Aldo: Solo tu potevi sbagliare macchina, guarda!
Aldo: E intanto nessuno se n'è accorto!
Figlio di Aldo: Papà, veramente io...
Aldo: Sta' zitto tu! Pensa piuttosto a giocare con le figurine dei calciatori!
Figlio di Aldo: Ma papà, a me piace la filosofia, hai presente Kant?
Aldo: Sì, come no, l'ho incontrato proprio ieri! Gli piace la filosofia... ma sei sicura che è figlio mio?
Suocera di Aldo: Be', veramente tu sei sempre in giro, vero?
Aldo: Ma che dici?!? Rita, hai qualche cosa da confessarmi?!
Rita: Ma che dici amore, è solo che ha gusti diversi dai suoi compagnetti!
Aldo: Gusti diversi?! In che senso?!
Figlio di Aldo: Io sono...
Aldo: Non lo dire, non lo voglio sapere!
Figlio di Aldo: Sono... 
Aldo: Non lo... [Tappandosi le orecchie] La-la-la-la-la-la-la-la... 
Figlio di Aldo: Sono agnostico, papà!
Aldo: [Tirando un sospiro di sollievo] Agnostico... E io che mi credevo che eri... Ma che vuol dire agnostico?
Suocera di Aldo: Omosessuale, no? Vieni da nonna, dai!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 155,
                column: "Content",
                value: @"Giovanni: E dai, dì qualcosa anche tu, cosa ti piace? [del posto dove si stanno recando in vacanza] 
Moglie di Giovanni: Cosa mi piace? Il viaggio di ritorno. 
[Giovanni improvvisamente frena] Giovanni: Eh no, eh! Non si parte con questo spirito! [Tutti quanti esultano] Questo è lo spirito giusto, bravi! [Riparte con la macchina]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 156,
                column: "Content",
                value: @"[Dopo aver assistito a una pallonata dei bambini sulla sua macchina] Eh no, eh! Eh no, eh no, eh no, eh! Guardate che ve lo buco quel pallone!
Aldo: Ma lasciali fare, son bambini!
Giovanni: No, sono i tuoi bambini! 
Aldo: Ora ci mettiamo a guardare se sono miei o sono tuoi, i bambini sono bambini. 
Giovanni: No, questi sono tuoi tuoi! 
Aldo [con aria spazientita]: Bambini, andate a giocare più lontano, va! 
Moglie di Aldo: Smettetela di litigare, eh, qui c'è il pane, le olive e il salame. 
Suocera di Aldo: Chi è che vuole una tazza di cioccolata?
Aldo: Ci sono 40 gradi all'ombra e tu ti metti a bere un Ciobar?
Suocera di Aldo: Bere caldo fa sentire freschi!
Aldo: Ma chi te le dice tutte 'ste minchiate?!
Giacomo [guardando il salame]: Ah però, trentasei euro al chilo! Colazione da Tiffany!
Aldo: Trentasei euro al chilo? Rita, ma sei matta?! Io mi spezzo la schiena in due e tu mi sperperi tutto il patrimonio? Ho un tenore di vita da Tronchetti Provera senza capitale e quella mi spende come Afef!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 157,
                column: "Content",
                value: @"Padre Bruno: Io ti assolvo nel nome del Padre, del Figlio e dello Spirito Santo, Amen. 
Signora: Grazie Padre. 
[Fuori campo] Mario: Vergogna. 
Signora: Come? 
Padre Bruno: Cosa c'è? 
Signora: Non so, mi è sembrato di sentire una voce, un rimprovero. 
Padre Bruno: Ecco, brava, continua ad ascoltare la voce del tuo cuore, figliola. 
Signora: Sì, Padre. [Va via] 
Padre Bruno: Mario... [Mario esce da dietro il confessionale] Quante volte te lo devo dire che non puoi ascoltare le confessioni? 
Mario: Quella donna ha messo le corna al marito e se la cava con tre Ave Maria?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 158,
                column: "Content",
                value: @"Mario [parlando con Padre Bruno dell'importanza della confessione]: Ma io ho tanto bisogno di Dio... 
Padre Bruno [aprendo la tendina del confessionale]: Tu hai tanta paura di andare all'Inferno! Da quant'è che non ti confessi? 
Mario: Be'... c'era ancora Pertini... abbiam vinto i mondiali... 2006? 
Padre Bruno: '82! [chiude la tendina del confessionale] 
Mario: Come passa il tempo...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 159,
                column: "Content",
                value: @"Mario: Già che è qua, Padre, ma la resurrezione riguarda solo l'anima o anche il corpo? 
Padre Bruno [stufo della solita domanda]: La resurrezione è dell'anima e del corpo. 
Mario: Ah, ma nel senso di carne e ossa...? 
Padre Bruno: Ahh, nel senso che l'uomo ritorna a Dio! 
Mario: Sì, ma col suo corpo o con un corpo diverso? 
Padre Bruno: Nel tuo caso sarebbe meglio che tu rinascessi con un corpo diverso!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 160,
                column: "Content",
                value: @"Beniamino [confessandosi]: Sono confuso, non ho dormito tutta la notte!
Padre Bruno: Tranquillo, figliolo, apri pure il tuo cuore, che qui siamo nella casa del Signore.
Mario: Sì, ma veniamo al dunque, padre!
Padre Bruno: Tu... levati di qua! Quante volte ti ho detto che non puoi ascoltare le confessioni?! [...]
Beniamino: Mi è caduta dal cielo!
Padre Bruno: Chi?
Beniamino: La valigia! [...]
Mario: Sì, ma cosa c'è dentro nella valigia?
Padre Bruno: Il Signore perdoni la nostra malsana curiosità... Cosa c'è nella valigia?
Beniamino: Soldi!
Padre Bruno: Soldi?! Quanti?
Beniamino: Tanti.
Padre Bruno: Tanti quanti?!
Beniamino: Troppi.
Padre Bruno: Troppi?!
Mario: Non sono mai troppi i soldi, Padre!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 161,
                column: "Content",
                value: @"Beniamino: Biscotti e vin santo? 
Mario: Ma ti sembra il momento? [prende e mangia un biscotto] Mmh, buoni! Sono artigianali? 
Beniamino: Sì: ""CroccaDog"". 
Mario [sputa disgustato il biscotto]: Ma son biscotti per cani! 
Beniamino: Ricchi di fibre, cereali, e frutta secca!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 162,
                column: "Content",
                value: @"Aldo: Ora provo il giro della morte! 
Giacomo: Ma no, non lo fare! 
Giovanni: Ci ha già provato il Conte di Montecristo, hai visto che cosa gli è successo? L'hanno rotolato dentro una tela e rinchiuso in uno sgabuzzino!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 163,
                column: "Content",
                value: @"Aldo: Je suis un cavalier! 
Giacomo e Giovanni: Cavaliere? 
Aldo: Oui? 
Giacomo e Giovanni: Prrrrrrrrrrr!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 164,
                column: "Content",
                value: @"Giovanni e Giacomo: Napoleon? 
Napoleone: Oui? 
Giovanni e Giacomo: Prrrrrrrrrrr!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 165,
                column: "Content",
                value: @"Giacomo: Com'è che si chiama [il figlio di Giovanni]?
Moglie di Giacomo: Saturnino.
Giacomo: Ma che nome è?
Moglie di Giacomo: È il nome del nonno.
Giacomo: Se il nonno si chiamava Nosferatu, chiamavano il bambino Nosferatu?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 166,
                column: "Content",
                value: @"Dott.ssa Gastani Frinzi: Hmm, no. Lo spermiogramma non ci dà delle belle notizie, hmm... La maggior parte degli spermatozoi è morta. I rimanenti possiedono una motilità scarsissima, direi. Desidera un caffè?
Giacomo: Sì grazie, se ci fosse un cafferino, magari...
Moglie di Giacomo: Amore, dai, lascia perdere, sei già abbastanza nervoso.
Giacomo: Ma non sono nervoso!
Moglie di Giacomo: E quindi la situazione quale sarebbe?
Dott.ssa Gastani Frinzi: Glielo spiego in altre parole: questi spermatozoi sono stanchi, sono deboli, non hanno proprio il vigore, non possono raggiungere l'obiettivo, non so come dire... sono impigriti, svogliati, sa, proprio senza nerbo... sono... poco motivati, poco motivati. Ma come mai, signor Poretti?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 167,
                column: "Content",
                value: @"Moglie di Giacomo: Ma non c'è proprio niente che possiamo fare? 
D.ssa Alexandra Gastani Frinzi: Si un paio di cose: o cambiare partner... ahahah, no, scherzavo, dai, scherzavo, non si intristisca, già questi sono depressi...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 168,
                column: "Content",
                value: @"Aldo: Mio figlio... si fa le canne...
Giovanni: Eh, col padre che si ritrova è un miracolo che non faccia lo stupratore...
Aldo: Forse commette anche quel reato...
Giovanni: Allora facciamo che da oggi non ci conosciamo.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 169,
                column: "Content",
                value: @"Dott.ssa Gastani Frinzi: Signor Poretti! Lei si è applicato? 
[Guardandosi con la moglie] Giacomo: ...Sì. 
Dott.ssa Gastani Frinzi: Eh, non sembra! Eh no, perché proprio questi spermatozoi non vogliono vincere, eh? Qui non c'è cattiveria, manca proprio lo sguardo della tigre in questi semini! 
[Guardandosi con la moglie] Giacomo: ...Semini?! 
Dott.ssa Gastani Frinzi: La temperatura basale l'avete presa? 
Moglie di Giacomo: Certo. 
Dott.ssa Gastani Frinzi: Sì, ma come ho detto io? 
Giacomo: Sì. 
Dott.ssa Gastani Frinzi: Sicuro? 
Giacomo: Sicuro. 
Dott.ssa Gastani Frinzi: ...Ve lo rispiego. 
Giacomo: Dottoressa, guardi che non siamo mica scemi. 
Moglie di Giacomo: Amore, non ti arrabbiare che fa male agli spermatozoi... no? Non c'è piuttosto un'altra possibilità? 
Dott.ssa Gastani Frinzi: Sì, secondo me a questo punto potete rivolgervi alla banca del seme. 
Giacomo: Sì, per un mutuo! 
Dott.ssa Gastani Finzi: Lo sa che io al suo posto non farei tanto lo spiritoso? 
Giacomo: Senta, Dottoressa Frinzi...
Dott.ssa Gastani Frinzi: Gastani Frinzi. 
Giacomo: Senti, Gastani Frinzi, lo sai che se ti trovo in giro in macchina io ti tiro sotto? 
Moglie di Giacomo: Amore, ma cosa dici? 
Giacomo: Tieni giù le mani porca di quella puttana! Gastani Frinzi dei miei coglioni! [Esce dalla stanza] Dove cazzo si esce in questo posto di merda?! 
Moglie di Giacomo: Scusi Dottoressa Frinzi. 
[Visibilmente perplessa] Dott.ssa Gastani Frinzi: ...Ga ..Gas... Gastani Frinzi. 
Giacomo: L'avete concepita una porta o no? 
Moglie di Giacomo: Volevo dire Gastani Frinzi, mi scusi. Facciamo con la segretaria, no? Amore! 
Giacomo: Ah, perché ti devo anche pagare? Ma vaffanculo va!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 170,
                column: "Content",
                value: @"Giovanni: Hai visto che gol di sinistro? Proprio sotto la traversa...
Aldo: Lo avrebbe fatto anche mio nonno!
Giovanni: Ma se è morto!
Aldo: Appunto. Mi passi lo shampoo?
Giovanni: E che cazzo te ne fai?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 171,
                column: "Content",
                value: @"Aldo [parlando di suo figlio]: Si è fatto bocciare. Che vergogna. 
Giacomo: Ma chi? 
Aldo: Il maggiore. 
Giacomo: Ah, ""lo scienziato""! 
Giovanni: Per forza, con tutte le canne che si fa. [Giacomo ride] 
Aldo: Ma ti rendi conto che è il primo dell'albero genealogico a farsi bocciare? 
Giovanni: Be', su questo ho molti dubbi. Credo che se cerchi bene tra i rami qualcuno c'è già. 
Aldo: Ma io lo mando a lavorare quel disgraziato. 
Giovanni: Ecco, in questo caso sarebbe proprio il primo dell'albero.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 172,
                column: "Content",
                value: @"Irene: C'è qualche terrone qui? [Giovanni e Giacomo fissando Aldo]
Aldo: Effettivamente sono nato a Palermo... però come ben può vedere ho delle forti contaminazioni normanne... poi mio papà mi ha iscritto qui, a metà strada tra le due culture... 
Irene: Ma che cazzo stai dicendo?!
Aldo [in preda alla disperazione]: La prego, dottoressa... c'è stato uno sbaglio: siamo innocenti!
Irene: Sei tu, sei tu che hai avuto la brillante idea di farvi beccare proprio stasera, eh?! Ma che razza di banda siete??");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 173,
                column: "Content",
                value: @"Giacomo: T'ha cacciato a pedate nel culo? 
Aldo: Ho avuto un misunderstanding! 
Giovanni: Cosa?! 
Aldo: Un pacato confronto tra persone adulte...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 174,
                column: "Content",
                value: @"Gualtiero: Certo che come giocatore sei proprio una merda! 
Aldo: Ma se sei tu che mi hai suggerito il tris sicuro! Dicevi he Gazzaladra era più veloce di un Porsche e aveva l'argento vivo di un termosifone! Gualtiero...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 175,
                column: "Content",
                value: @"Giacomo: Ludmilla! Una colonscopia al paziente ventitré! 
Paziente: Ohhh, che super-io spigoloso! 
Giacomo: Vedrà che colonscopia spigolosa!");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: @"Giacomo [al telefono con Giovanni]: Pronto? 
Giovanni: Giacomo, tutto a posto? 
Giacomo: Sì, è tutto a posto... senti, mi chiami dopo che mi sta finendo il film? 
Giovanni: No, stiamo chiudendo, dai! A proposito, dove hai messo le rondelle del sei, che Aldo non le trova? 
Giacomo: Cosa ne so io delle rondelle del sei, dai, chiamami dopo, dai! 
Giovanni: Senti, le commissioni le hai fatte? 
Giacomo: Le ho fatte tutte, sì. 
Giovanni: Il vestito l'hai ritirato?
Giacomo: Eh, secondo te mi sposo nudo?
Giovanni: Eh... gli anelli?
Giacomo: Ma che palle che sei! Certo che li ho ritirati gli anelli!
Giovanni: Anche le scarpe?
Giacomo: Le scarpe le ho ri... Porca puttana, le scarpe!
Giovanni: Hai visto? Se non ti telefonavo io ti sposavi in ciabatte! 
Giacomo: Vabbe' dai, se mi sbrigo riesco a andare a ritirarle, dai! 
Giovanni: Ah, a proposito, il pacco è arrivato, eh... domattina andiamo a ritirarlo prima di partire. Senti, ti vengo a prendere verso le... sette e mezza. 
Giacomo: Ma come le sette e mezza? 
Giovanni: Vabbe'... sette e un quarto. Ciao!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: @"Giacomo [verso la casa di Aldo]: Aldo! Aldo! 
Giovanni e Giacomo [urlando]: Aldo!! 
Giovanni: Aldo! 
Giacomo [urlando]: Aldooo!! 
Giovanni: Allora?!? 
Giacomo [urlando di più]: Aldoooo!!! 
Aldo [nella finestra]: Allora, che c'è!? 
Giovanni: E che ha detto alle otto, sono le otto e sette! 
Aldo: E c'è bisogno di gridare così?! Qui c'è gente che mi conosce! 
Giacomo: Dai, su, sbrigati, scendi, che dobbiamo anche ritirare il pacco, dai! 
Aldo: Va be', finisco di mangiare la peperonata e scendo! 
Giovanni [a Giacomo]: Peperonata? Alle otto del mattino? Mezzogiorno... topi morti?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: @"Portinaia: Signor Giovanni! Signor Giovanni! Buongiorno signor Giovanni... come sta la sua signora? È già giù al mare che l'aspetta, nè? Ma lei non è geloso? 
Giovanni: Be'... 
Portinaia: Eh, me la saluti tanto, tanto... e lei, signor Giacomo! Il grande giorno si avvicina, eh? Paura? 
Giacomo: Mah, insomma, ancora tre giorni e poi mi sposo... 
Portinaia: Eh, era ora che facesse qualcosa anche lei, eh! Così siete a posto tutti e tre, finalmente! A proposito, se non togliete la macchina lì davanti al portone immediatamente, io ve la faccio rigare da mio marito! E poi ve la faccio anche portar via dai vigili! Capito? Eheheh! [a Giovanni] Buon viaggio, nè! [a Giacomo] Buon viaggio anche a lei, nè!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: @"[Aldo ruba il posto in macchina a Giacomo proprio quando si sta sedendo]
Aldo: Scusa! 
Giacomo: Ma come 'scusa'? Arrivi, neanche saluti e mi ciuli il posto?
Aldo: Hai ragione. Ciao, come stai? Andiamo Giovanni, che è tardi!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: @"Donna: Ma chi sono quelli là? 
Portinaia: Ma come chi sono? Quelli là son dei mantenuti! 
Donna: Ma chi? 
Portinaia: Due hanno sposato le sorelle Cecconi, e l'altro sta per attaccare il cappello con la più giovane, la terza! 
Donna: Mmmh!... 
Portinaia: E adesso stanno andando giù nel meridione, nelle Puglie, per fare il matrimonio, perché il cavalier Cecconi vuole celebrarlo giù a Gallipoli dov'è nata sua moglie! 
Donna: Ma, scusi, le figlie del dottor Cecconi...? 
Portinaia: Certo! Sì, quello che ha quella grande catena di negozi di ferramenta, che se non fosse per lui, ti dico la verità, io ti assicuro che quei tre lì a quest'ora sarebbero in mezzo alla strada!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: @"[In macchina] 
Giovanni: Scusa, puoi togliere i piedi dal cruscotto, che lo sporchi?
Aldo: Mi', come sei pignolo! 
Giovanni: Io sono pignolo? 
Giacomo: Be', un po' pignolo lo sei! 
Giovanni: Cioè, questo qua mi cammina sul cruscotto ed io sarei pignolo! 
Giacomo: Capito, ma devi anche saperle accettare le critiche, sennò... 
Giovanni: Va be', allora, visto che sono pignolo: puoi spostare la gambetta sennò non entran le marce? 
Aldo: Lo vedi che sei veramente pignolo? 
Giovanni: Ecco, allora facciamo tutto il viaggio in prima perché sennò io sarei pignolo! Comunque mettiti le cinture, che se facciamo un incidente e sbatti l'assicurazione non paga. 
Aldo: Ma a che serve? Stiamo andando a trenta all'ora! 
[Giovanni frena di colpo e Aldo sbatte la testa sul cruscotto] 
Giovanni: Visto? 
Giacomo: Allora sei bastardo! 
Giovanni: E pignolo!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 7,
                column: "Content",
                value: @"Giovanni: Allora io vado a prendere il pacco, tu... non so... vai a prendere...
Giacomo: Scusa, ma possibile che quando c'è un lavoro di responsabilità devi farlo sempre tu? Cos'è, io non son capace?
Giovanni: No. Però, se vuoi andare...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 8,
                column: "Content",
                value: @"Giovanni [parlando della scultura]: Cos'è 'sta roba? Scusate ma... centosettanta milioni per questa merdina qua? Ma dai, è una follia!
Giacomo: Ma che follia, che follia!? Ma lo sai che questo qui è un Garpez, uno dei più grandi scultori viventi?
Giovanni: Ma scultore che cosa? Ma guarda che il mio falegname con trentamila lire la fa meglio, va', non ha neanche le unghie!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 9,
                column: "Content",
                value: @"Cecconi: Lo sai come so' fatti 'sti artisti... Mezzi drogati, mezzi froci... ma comunque, se 'more, la gamba fa un sarto [salto], uno zompo, e va a trecento milioni! Ma che sto a di', a te, che nun capisci niente, su! Per piacere, a' nano [sarebbe Giacomo], e passame er pignolo [sarebbe Giovanni], và! Pronto, pignolo? Andò state?
Giovanni: Eh, è poco che siam partiti, avremo fatto... quaranta chilometri!
Cecconi: Aoh, 'a pigno', ma dovete sbrigarve, dovete còre! [correre] Perché stasera c'abbiamo una cena! Sì, siete tutti invitati ar Gambrinuse, ar ristorante! Così ve presento er prete. Oh, me raccomando, eh... nun me fate fa' figure de merda! Mi raccomando! [il cane Ringhio abbaia] Oh... oh, oh, sento Ringhio! Ah, ah, Ringhio, a papà, fa sentì 'a vocetta tua! [il cane Ringhio abbaia forte] Eheheh, meno male che ce sei te, Ringhio... eh, sei l'unico che me dà soddisfazione...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 10,
                column: "Content",
                value: @"Giacomo: Scusa, puoi tirar su il finestrino? Lo sai che ho avuto problemi al trigemino quest'anno. [Giovanni chiude il finestrino ed accende l'aria condizionata] Ti dico di tirar su il finestrino, mi accendi l'aria condizionata? Ho già fatto tre bronchiti quest'anno! 
Giovanni: Ho capito, se fumi attacco l'aria condizionata, cosa faccio, accendo la radio? 
Giacomo: No, la radio no perché ho già un po' di mal di testa. 
Giovanni: Sì, ma se lo dicevi prima ci portavamo dietro il polmone d'acciaio! Eh cazzo!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 11,
                column: "Content",
                value: @"Aldo: Oh! Ti fermi che devo fare pipì? 
Giovanni: Eh, adesso mi fermo ogni due minuti perché devi far pipì? 
Aldo: Va bene, allora ti piscio in macchina!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 12,
                column: "Content",
                value: @"Giovanni: Senti, lega il mostro [il cane Ringhio] alla macchina, così ci fa anche la guardia. 
Aldo: Ma perché, non può venire? 
Giovanni: Chi, la merdina? 
Aldo: Dammi qua, per l'amore della pace, va!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 13,
                column: "Content",
                value: @"Aldo: Ma quanti libri legge quello lì [Giacomo]? 
Giovanni: Ma neanche uno! Ne compra cento al mese e non gliene ho visto sfogliare uno!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 14,
                column: "Content",
                value: @"Giovanni [Dopo che lui e Giacomo hanno visto che il cane Ringhio non c'è più]: Be', così è la vita...
Aldo [piangendo arrabbiato]: Con te non ci parlo più, sei un assassino!
Giovanni: Io?!? A parte che sei stato tu a legarlo [Ringhio] dietro!
Aldo: Sì ma sei tu il piede che gli ha dato la morte!
Giacomo: Dai, quel che è stato è stato, è inutile star qui a litigare per questo!
Giovanni: ""Quel che è stato è stato"" un paio di balle! Chi è che glielo dice adesso al vecchio? [Cecconi]
Aldo: Quello prima ci apre la testa e poi ci sputa dentro!
Giovanni: E poi ci licenzia!
Giacomo: Certo che voi due siete proprio dei conigli, dai! Ma che paura dovete avere? Siamo delle persone civili o no? Lo si chiama e gli si spiega che è stato un incidente!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 15,
                column: "Content",
                value: @"Giacomo: Non sento nessun rumorino, a parte che ho appena avuto l'otite e non ci sento molto bene!
Giovanni: Allora sei 'na discarica!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 16,
                column: "Content",
                value: @"Giacomo [parlando di Chiara]: Oh, però è carina, eh? 
Giovanni: Carina è carina, sì. 
Giacomo: Ma non è solo carina, c'ha anche quell'aria lì un po' particolare, un po', eh...? 
Giovanni: Sì, c'ha quella roba lì, però calcola che tra due giorni ti sposi, eh! 
Giacomo: Perché, cosa ho detto di male? 
Giovanni: Be', sei sempre lì a far lo scemetto, gli occhi dolci, tì-tì-tì-tì... 
Giacomo: Che occhi dolci, ma cosa stai dicendo?! Ma Aldo, sto facendo lo scemo? 
Aldo: Be', un po' lo scemo lo stai facendo, va! 
Giovanni: Cioè, abbiam fatto la constatazione amichevole [Chiara ha tamponato l'auto del trio] e a momenti avevo torto io! 
Aldo: Be', insomma, tutte le ragioni non ce le avevi!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 17,
                column: "Content",
                value: @"Giacomo [a Chiara]: Tutto a posto? 
Chiara: Sì, per fortuna sono riuscita a spostare il traghetto, altrimenti addio vacanze! 
Giacomo: Traghetto per...? 
Chiara: Ah, Grecia. Faccio Brindisi-Patrasso, poi un giro per le isole... 
Giacomo: Vai a raggiungere... il fidanzato? 
Chiara [imbarazzata e giù di morale]: No... 
Giovanni: Toccato un tasto dolente? [Chiara annuisce] Vi siete appena lasciati. 
Chiara: Hmmm-mm. 
Giovanni: Ti ha mollato lui! 
Chiara [sull'orlo delle lacrime]: Hmmm-mm! 
Giovanni [tra sé e sé]: Si vede. 
Giacomo [tra sé e sé, rivolto a Giovanni]: Sei un deficiente! 
Giovanni: Con la tua migliore amica! [Chiara piange] 
Giacomo: Ma smettila, Giovanni! 
Giovanni: Be', lo dicevo così, per rompere il ghiaccio... 
Chiara [asciugando gli occhi]: Scusate... [al trio] Voi... siete musicisti? 
Giovanni: Come? 
Chiara: Nella custodia cosa c'è, un sax? 
Giovanni: Ah, lì... no, c'è una roba... 
Giacomo: E' un'opera d'arte, è una scultura? 
Chiara: Posso vederla? 
Giovanni: Eh no, ciccia, non è che possiamo farla vedere a chiunque! 
Giacomo: Come no, Giovanni, dai, fagliela vedere! 
Giovanni [sospirando]: Fagliela vedere... [prende la gamba e la dà a Chiara] Ecco, vedi? Guarda qua... 
Chiara: No... 
Giovanni: Eh sì, eh, purtroppo sì, eh... 
Chiara: Non è possibile, quest... è autentica? 
Giovanni: Eh, la gamba! 
Chiara: Questo è un Garpez! 
Giacomo: Ma scusa, ma come hai fatto così al volo? 
Giovanni: Per forza, è una merda, è un Garpez! Anzi, ciccia, visto che costa una cifra... [se la fa ridare] Bella, però... 
Chiara: Sì, lo so... io ho a che fare con le opere d'arte per lavoro. Sì, insomma, faccio la restauratrice. 
Giacomo: Ma va? Ma lo sai che è sempre stato il sogno della mia vita fare il re...? [Aldo e Giovanni scoppiano a ridere in crepapelle] 
Giovanni: Ma se non sai neanche unire i puntini della settimana enigmistica, Giacomo! 
Aldo: L'ho capita adesso! 
Giovanni: Ma c'è da ammazzarsi dal ridere! 
Chiara: E voi? 
Giovanni: Eh? 
Chiara: Cosa fate nella vita?
Giovanni: Be', noi... lavoriamo nella meccanica di precisione, tecnologie avanzate al servizio di progettazioni particolari e specifiche. Non so... ""harware""... 
Giacomo: Hardware! 
Giovanni: Hardware e quelle cose... cioè, creiamo dei supporti che poi serviranno per progettare grosse situazioni, non so, mecc... Proprio... Strumenti di precisione per una svolta magari futura anche della meccanica... eh, non so se mi spiego...
Aldo: Sì, insomma... Abbiamo un negozio di ferramenta... Cioè, non è che il negozio di ferramenta è nostro... noi ci lavoriamo come commessi, come galoppini, insomma, come... come... sì...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 18,
                column: "Content",
                value: @"[Nel cinema, mentre cercano il meccanico] 
Chiara: Oh! Oh! Oh! Oh! Oh! È un Garpelli! 
Giovanni: Chi? 
Chiara: È un film di Garpelli, neorealista. Non lo proiettano da trent'anni! 
Giovanni: Ci sarà il suo motivo, dai! 
Chiara: Non possiamo perderlo, vi prego! 
Giovanni: Ma no, ma... Giacomo! 
Giacomo: Eh, è un Garpelli, Giovanni! 
Giovanni: Ma dai! Aldo! 
Aldo: Vado a prendere i popcorn!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 19,
                column: "Content",
                value: @"Dottore [rivolgendosi a Giacomo]: Dunque, vediamo, nome e cognome? 
Aldo: Giacomo Poretti. 

Aldo: Ma lo conosco, è mio cognato... 
Dottore: E secondo lei io devo compilare un documento che è ufficiale mettendo le informazioni del primo che passa? [a Giacomo] Senta, è suo cognato? 
Giacomo: Si, si... 
Dottore [rivolgendosi ora ad Aldo]: Va bene, come ha detto che si chiama? 
Aldo: Perché non glielo chiede a lui? 
Giovanni: Giacomo Poretti... per favore, siamo in ritardo! [sottovoce ad Aldo] Non star lì sempre a questionare...
Dottore [scrive]: Gia-como... Po-ret-ti... Allora... vediamo un po'... se tocco qui fa male? [lo tocca, e Giacomo emette un verso di dolore] Ma è sicuro, eh? [lo tocca di nuovo, e Giacomo urla di dolore più forte] Invece se tocco qui?
Giacomo No!... 
Aldo: Dottore, perché non gli diamo un calmante per endovenosa... che ne so io, quattro cc di placibio?... 
Dottore: Ah, è medico! Non lo sapevo... È medico! E dov'è che ha studiato? Mi faccia il sacrosanto piacere di mettersi lì e di stare zitto, e non disturbi, mentre faccio il mio lavoro! Signorina, mi prepari un calmante, dunque vediamo... Quattro cc di placibio per endovena. [Aldo è visibilmente contrariato]. Ecco, la lingua, mi faccia vedere la lingua...
Aldo: Dottore, secondo me ha un colica renale. 
Dottore: Che cosa le ho detto prima? Di stare...?
Aldo: Zitto...
Dottore: E di mettersi... lì.
Aldo: Si, però, è...
Dottore: Sono io che faccio le visite. Hai capito? 
Aldo: Sì, però se tocchiamo qui [tocca Giacomo, che urla di dolore] e gli fa male non può essere una tracheite! 
Dottore: Adesso si mette anche a fare le diagnosi! È arrivato il professorone, è arrivato! Sa cosa faccio adesso? Mi tolgo il camice... mi tolgo il camice e lo do a lei, va bene? Glielo do? Vuole il camice? Stia zitto! Non voglio più sentire neanche una parola capito?! Zitto! [rivolgendosi nuovamente a Giacomo] Caro signor...
Aldo: Giacomo Poretti.
Dottore: Caro signor Poretti, qui abbiamo una bella colica renale! [Aldo fa nuovamente la faccia scocciata] Dobbiamo fare qualche esamino, lei questa notte la passa qui dentro. Motivi precauzionali. 
Giovanni: Guardi che siamo già in ritardo incredibile... 
Aldo: Non è che ti puoi mettere a discutere col professore, è un professorone! Un professorone di stirpe, non è che si è inventato, sa quello che deve dire.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 20,
                column: "Content",
                value: @"[In ospedale, Giovanni guarda fuori dalla finestra] 
Giovanni: Oh cazzo, la macchina! [Chiara] Ci ha ciulato la macchina! Ma... [rivolto a Giacomo] Hai visto? Quella tua amichetta, eh, e la Grecia, e la mitologia, e tagliamo la mela, e intanto ci ha ciulato la macchina con dentro la gamba! E io pirla, che le ho lasciato anche le chiavi! Quella grandissima... [Chiara entra nella stanza e Giovanni sorride] Chiara! 
Chiara: Voi siete matti a lasciare giù la gamba... e se ve la rubano? Ah, la... macchina l'ho messa all'ombra, era sotto il sole...
Giovanni: Brava! 
Chiara: E... questa è la tua borsa, no, Giacomo? 
Giacomo: Si... 
Chiara: Il pigiama dov'è? 
Giacomo: Eh... non c'è il pigiama. 
Chiara: Non c'è il pigiama? 
Giacomo: Eh... dormo nudo... 
Giovanni: Dormi nudo? Tu c'hai due bronchiti al giorno e dormi nudo? 
Aldo: Eeeeh, ragazzi, stiamo calmi, non è successo niente, vorrà dire che gli presterò il mio!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 21,
                column: "Content",
                value: @"[Vedendo Giacomo con indosso la maglietta che gli ha prestato Aldo]
Giovanni: Sì, però, anche tu... ti sembra il caso di dormire con la maglietta di Sforza? 
Aldo: Eh, quella di Ronaldo era finita! [Giovanni sbatte furiosamente Aldo dietro a testa la porta vetrata, che gli geme di dolore atroce]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 22,
                column: "Content",
                value: @"Giovanni: Lo sai che con venti milioni si può comprare un bar in Costa Rica? Sulla spiaggia. Sole, mare, un sacco di palme. 
Aldo: Tutto l'anno in costume.
Giovanni: Tutto l'anno in costume. Nessuno che ti rompe le palle; che ti dice quello che devi fare. Certo, ci vuole coraggio, bisogna abbandonare tutto.
Aldo: E se ti va male?
Giovanni: Be', il rischio c'è. Del resto, se non rischi. Tu hai mai rischiato?
Aldo: Una volta: una volta ho messo due fisso a Inter-Cagliari.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 23,
                column: "Content",
                value: @"Aldo: Ragazzi! Ragazzi! Ho trovato il nuovo Ringhio!
Giovanni: Ma se è nero!
Aldo: Ma perché, devi essere razzista anche coi cani?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 24,
                column: "Content",
                value: @"Chiara: E così domani ti sposi? 
Giacomo: Sì, ma niente di serio.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 25,
                column: "Content",
                value: @"Giovanni [rivolto ad Aldo che ha appena gettato la ruota di scorta nel fiume, che però non regge]: Ma sei deficiente!?
Aldo: Eh, mi credevo che galleggiava...
Giovanni: Ma se solo il cerchione pesa trenta chili!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 26,
                column: "Content",
                value: @"Jack: Se al mattino spacchi le pietre, al pomeriggio scavi le buche. Se al pomeriggio si spaccano le pietre, al mattino si scavano le buche. Se al mattino... 
Al: Se al mattino spacchi le palle, la sera pure! 
Jack: Ma che minchia di programma rieducativo è?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 27,
                column: "Content",
                value: @"Al [raccontando una barzelletta]: C'è un tipo di colore...
Jack: Che tipo di colore?
Al: Un tipo di colore!
Jack: Sì, ho capito, ma rosso, verde...
Al: Mii, un negro! Un tipo di colore negro! [...] Allora... c'è un negro che bussa alla porta di un night club...
John: Ah, ho capito... è quella che poi apre lo spioncino e lo tira fuori con le dita nel naso!
Al: Ecco, ho capito quella che dici. È bellissima! È un capolavoro della barzelletta. Ma non è quella!
Jack: Ma qual è quella che lo tira fuori con lo spioncino?
Al: Mii Jack, sto raccontando un'altra barzelletta! [...] Allora... c'è un negro che bussa alla porta di un night club...
John: Aaah... è quella che poi lui va in un altro night club!
Al: Quella!
John: Che lui corre forte...
Al: Sì, però non me la rovinare... lasciamela raccontare. 
Jack: Ma quando si ride in questa barzelletta?
John: Jack, è una barzelletta e si ride alla fine!
Al: [...] T'hanno dato trent'anni, puoi anche aspettare!
Jack: Va bene, allora... allora aspetteremo!
John: Aspetta un attimo Al, ma come mai a lui hanno dato trent'anni e a noi cinquanta?
Al: Mii Johnny, pure tu... sto raccontando una barzelletta! Mii, la sto odiando 'sta barzelletta! Allora: c'è 'sto cazzo di negro che è due ore fuori dalla porta di questo night club di mmerda! E il portiere gli risponde... 
John: Non si può entrare in questo night club. [...]
Al: E il negro gli risponde... 
John: Ma lei non sa chi sono io, mi faccia entrare!
Jack: Lei non sa chi sono io! Ma che t'inventi Johnny! 
Al: E... e il portiere gli risponde...
John: Guarda quella ragazza con la gonna rossa!
Jack: Con la gonna rossa! Miinchia! Sto scompisciando dalle risate! Haha...
Al: Ragazza... con la gonna rossa?
John: Sì...
Al: Allora non è lei...
John: Come non è? Non è che poi dice: ""Oh, c'è anche l'elefante che parla inglese...""
Jack: L'elefante che parla inglese! Johnny, sei veramente una bomba, sei! [...] Ma come finisce 'sta barzelletta?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 28,
                column: "Content",
                value: @"Giacomo: Ciao. Cosa stai leggendo oggi? 
Platone: Schopenhauer. 
Giacomo: Schopenhauer? 
Platone: Il mondo come volontà e rappresentazione. 
Giacomo: Sì, ma Platone, anche tu! Non puoi leggere Topolino come tutti gli altri bambini? Ciao Gaber! Ehi? Successo qualcosa? 
Gaber: Questa è arrivata stamattina. [Mostrando a Giacomo una lettera] Dice che dobbiamo partire entro stasera, neanche il tempo di fare le valigie ci hanno dato. 
Giacomo: Ma scusa, e per ora dove andreste? 
Gaber: Per ora da mio cugino poi boh... son disperato Giacomo. 
Giacomo: Non ti preoccupare; mi farò venire in mente qualcosa. 
Cognato di Giacomo: Ah, guarda che ber quadretto. Ammazza che schifo! Ahò, Africa! Damme un giudizio: te sembrano pulite 'ste scale? 
Gaber: Le ho appena pulite. 
Cognato di Giacomo: Va be'! Tanto tra un po' la pacchia è finita, eh? 
Giacomo: Intanto stiamo calmi, poi mi devi una spiegazione: Come mai non ne sapevo niente di 'sta roba? 
Cognato di Giacomo: Ahò! Ah Malcolm X! Intanto stai carmo te. Primo. Secondo: famo 'na bella cosa; al posto di ""unanimità"", ce scriviamo: ""Voti favorevoli: 15; voti contrari: 1"". Er tuo, eh? Giacomino, l'amico dii negri. Ciao, Congo.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 29,
                column: "Content",
                value: @"Giovanni: Io avevo un appuntamento importantissimo! 
Giacomo: Sì, dal pediatra.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 30,
                column: "Content",
                value: @"Giacomo: Anzi! Se proprio vuoi saperlo, io il poliziotto non volevo neanche farlo. È capitato. 
Giovanni: Eh, e se non capitava era meglio!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 31,
                column: "Content",
                value: @"Giacomo: Sai com'è la vita, capitano delle cose più grosse di te e devi prendere delle decisioni, un po' come il bivio di prima, ti ricordi, ""Che faccio? Vado a destra o vado a sinistra?"" E lì se non stai attento rischi di sbagliare, rischi di prendere la strada sbagliata. 
Giovanni: E tu l'hai presa in pieno, contromano!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 32,
                column: "Content",
                value: @"Giacomo: Tra l'altro ho anche finito di scrivere un romanzo. 
Giovanni [sarcastico]: Non vedo l'ora di leggerlo, c'ho l'acquolina in bocca.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 33,
                column: "Content",
                value: @"Aldo: In Africa, tutte le mattine, quando sorge il sole, una gazzella muore. 
Clara: Muore? 
Aldo: Si sveglia già morta, perché si vede che non stava molto bene il giorno prima e allora... Comunque, sempre in Africa, no? Tutte le mattine, quando sorge il sole, un leone, appena si sveglia, comincia a correre per evitare di fare la fine della gazzella che è morta il giorno prima. E poi, correndo, vede che c'è la gazzella morta il giorno prima lì e visto che... ""Che cosa corro a fare? Mi fermo e gli do due mozzicate"". Comunque, dove voglio arrivare? Non è importante che tu sei un crotalo o un pavone. L'importante è che se muori, me lo dici prima.[1]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 34,
                column: "Content",
                value: @"Aldo: Pronto, chi è? Chi? Giovanni Storti? E lei chi è? Ah, è la moglie.
Giovanni: Mia moglie.
Aldo: Stai fermo con le mani! Non lo so se ha sbagliato numero ma sicuramente ha sbagliato persona, o forse ha sbagliato numero ma ha trovato la persona giusta, o ... mi'! M'ha mandato a fanculo! Lo stesso carattere del marito! Mi', che famiglia! Sequestrato... anzi eliminato! [Riferito al telefonino che butta dal finestrino]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 35,
                column: "Content",
                value: @"Catania: Minchia già incazzato?? 
Giacomo: Sì, dai. Metti in moto che siamo già in ritardo. 
Catania: Ah, senti, c'è stato un cambiamento nel programma. 
Giacomo: Che cambiamento? 
Catania: Prima di passare dal carcere, devo fare una commissione. 
Giacomo: Catania cosa ti stai inventando stavolta? 
Catania: Quanto bene mi vuoi Giacomo? dammi la mano... e dammi sta cazzo di mano!... 
Giacomo: Ma dai! 
Catania: Hai sentito? Sai cosa vuol dire quando batte così il cuore? Guardami in faccia quando ti parlo. Lo sai cosa vuol dire? 
Giacomo: Ho paura di saperlo, Catania. 
Catania: Quanti favori t'ho fatto Giacomo eh?! Dimmi, quanti favori t'ho fatto?? 
Giacomo: Devo essere sincero? 
Catania: Non far lo stronzo... Giacomo ti prego non far lo stronzo! Io sto mettendo la mia vita nelle tue mani e tu fai lo stronzo? Non lo fare perché io per te... io per te... e dammi un bacio... quanto cazzo di bene ti voglio!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 36,
                column: "Content",
                value: @"Giacomo: Catania hai letto il regolamento? Non posso recuperare un delinquente da solo. 
Catania: Ecco quando fai così mi fai davvero incazzare! Ma come?! Tu sei il mio migliore amico io per te finirei pure in galera e tu? Come mi stai trattando? No dimmi come mi stai trattando??? Vaffanculo Giacomo... e dammi un bacio. 
Giacomo: Basta con 'sti baci e guarda sta strada! Piuttosto dimmi chi è stavolta e la facciamo finita. 
Catania: Aaaah perché tu credi che ci sia di mezzo una donna eh?! No, questa non è una donna. Questa è un'opera d'arte... una scultura... bella come una statua, una statua di... va bè adesso non mi viene in mente nemmeno il nome, ma guarda, ti giuro è perfetta... ecco io posso scendere anche qui ora... 
Giacomo: Catania... 
Catania: Io faccio un favore a te e tu uno a me. 
Giacomo: Catania... 
Catania: Così è la vita... a proposito: l'hai finito il tuo libro? Vedi che cazzo d'amico che sono! Tutto mi ricordo tutto! 
Giacomo: Allora... Allora adesso tu fai un favore a me: scendi dalla macchina e ti levi dalle palle, su andare! 
Catania: Allora ci vediamo qui alle undici.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 37,
                column: "Content",
                value: @"Aldo: Vuoi un po' di cheeseburger? 
Giacomo: No, grazie. Io faccio una dieta dissociata; cerco di non mischiare i carboidrati con le proteine..sai, perché se gli enzimi dei carboidrati... 
Aldo: Mii, e che devi farmi la cartella clinica?!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 38,
                column: "Content",
                value: @"Aldo: Ma perché? Perché, perché, perché mi fai questo? Perché mi devi mettere sempre i bastoni fra le ruote, eh? Mentre sto operando, oltretutto!
Marito della partoriente: È uscita la testa! È uscita la testa!
Aldo: Eh Ho capito, un minuto! Un minuto! Ha aspettato undici mesi, può aspettare anche un minuto, no? E tutto io devo fare? Ritorniamo a noi: Perché? Eh? Fammi vedere le mani. [Giovanni fa segno di no con la testa] Fammi vedere le mani, imperativo categorico assoluto! [Giovanni gli fa vedere le mani] O tu, o io? Che c'è scritto?
Giovanni: Niente!
Aldo: O io o tu?
Giovanni: Sì, è un gioco di parole...
Aldo: E come si risolve?
Giacomo: Ma niente, è che devi leggerle al contrario... ed esce scritto aiuto, c'è scritto.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 39,
                column: "Content",
                value: @"Aldo [mangiando un hamburger]: Il nettare degli dei. E il settimo giorno, Dio creò il cheeseburger. [Rivolgendosi a Giovanni] Ma come fa a non piacert... [Gli parte inavvertitamente un colpo dalla pistola che ha in mano. Il retro della macchina si sporca di rosso] Maria! Che ho fatto, Maria, che ho fatto? Gli ho spappolato la faccia, gli ho spappolato! Gli ho spappolato il cervello!
Giovanni: Non sento più niente! Oddio, non sento più niente! Non sento dolore!
Aldo: Sento che già il cadavere puzza! Sta frollando? Sta frollando?
Giovanni: Non sento più niente!
Giacomo: Ci credo che non senti niente, deficienti! È ketchup! Hai assassinato il sacchetto d'hamburger, hai assassinato!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 40,
                column: "Content",
                value: @"Aldo [puntandosi la pistola alla tempia]: Datemi un buon motivo per non farlo.
Giovanni: Be', adesso non me ne viene in mente neanche uno, però pensandoci bene, magari...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 41,
                column: "Content",
                value: @"Giovanni [riferendosi ad Aldo]: Oh cacchio, è con una ragazza?!
Giacomo: Sì.
Giovanni: Ma come sì... C'è lì il mostro di Dusseldorf con una ragazza e tu non fai niente, non agisci?
Giacomo: Perché?
Giovanni: Ma come perché, è un delinquente questo qua!
Giacomo: Ma scusa, adesso secondo te uno basta che finisca una volta in galera e diventa uno stupratore... Va' che tu, della natura umana, non capisci proprio un cazzo!
Giovanni: Senti, natura umana, è due giorni che te lo voglio dire! Sei proprio un cretino, va bene?
Giacomo: Che cosa hai detto?
Giovanni: Ho detto che sei un cretino, hai capito bene!
Giacomo: Guarda, faccio finta di non sentire! E poi comunque ti ricordo che stai parlando con un pubblico ufficiale!
Giovanni [ride]: Ma pubblico ufficiale che cosa, ma ti sei visto? Ma sei vestito come uno spaventa-passeri, e sai perché? Perché sei uno spaventa-passeri!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 42,
                column: "Content",
                value: @"Aldo: Ti chiami Clara?! Bellissimo nome! Pensa che quando ero bambino, e quando dico bambino... dico bambino! Conoscevo un'amica che si chiamava Francesca... E indovina come la chiamavo?
Clara: Clara.
Aldo: Eh no. Si chiamava Francesca... E la chiamavo Francesca.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 43,
                column: "Content",
                value: @"Giovanni: Hai capito?
Aldo: Non sono mica sordo!
Giovanni: Ciccio, quello è sentire, capire è un'altra cosa!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 44,
                column: "Content",
                value: @"Giovanni [discutendo sulla reazione dei parenti alle loro morti]: Ma sì... Il discorso di fondo è uno solo: non è che tutti gli esseri umani di fronte al dolore hanno la stessa reazione. Non so, prendi una vedova araba: urla, strepita, si strappa i capelli, si rotola... Una svedese no! Al massimo una lacrimuccia. Non è che soffra meno, è una reazione diversa di fronte al dolore. Mia moglie ha avuto una reazione di questo tipo.
Giacomo: Ma sì, un po' svedese. Come mia sorella e mio cognato.
Giovanni: Be', be' no eh, tua sorella e tuo cognato sono proprio dei bei bastardi. 
Giacomo: Ma come bastardi?
Giovanni: Ma sì, scusa, sei appena morto e ti affittano la camera e buttano il libro della tua vita nella spazzatura? Se non son bastardi questi qua, dai...
Giacomo: Scusa, e allora tua moglie?
Giovanni: Cosa vuol dire, lì è una reazione diversa.
Giacomo: Ma reazione diversa che cosa?! Scusa, sei morto da un giorno e si mette a trombare con un altro, dai!
Giovanni: Ma cosa vuol dire? È lo shock!
Giacomo: Ma lo shock di che cosa? Giovanni, è brutto sentirselo dire, ma tua moglie è proprio un bel puttanone!
Giovanni: Wè Giacomo, piano con le parole eh! Ahahahah, questa è bella! Mia moglie è un puttanone! Ma dai, mi fai ridere mi fai, ecco cosa mi fai! Adesso mia moglie è un puttanone... Ma pensa te! Mia moglie è un puttanone... [Con tono sempre più convinto] Mia moglie è un puttanone...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 45,
                column: "Content",
                value: @"Giacomo: Non mi vedi da tre anni e mi sbatti la porta in faccia!?
Giovanni: Che cosa vuoi?
Giacomo: Senti, lo so che è tardi, però è successa una roba...
Giovanni [con tono aggressivo]: Che cazzo vuoi?!
Giacomo: Aldo sta male!
Aldo [voce fuori campo]: Eppure, tre anni fa le cose erano molto diverse!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 46,
                column: "Content",
                value: @"Aldo: Oh, eh, Giovanni, quando vuoi venire non ti fare scrupoli, eh? Questa casa è sempre aperta per te. Eh? Non ti fare scrupoli, vieni quando vuoi, hai capito?
Giovanni: Scrupoli, è mia! Non è che...
Aldo: Comunque, magari una telefonatina prima, eh? Oh, Giacomino, anche tu, quando vuoi venire vieni, qua la porta... Allora, qui gente che entra, gente che esce, la facciamo diventare quello che vogliamo!
Giovanni: No!
Aldo: Mangiamo, beviamo, di giorno, di notte...
Giovanni: No!
Aldo: Ci ubriachiamo, eh, spacchiamo tutto, la radiamo al suolo questa merda di casa! 
Giovanni: Allora, no, no, no, un attimo! Mettiamo le cose in chiaro!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 47,
                column: "Content",
                value: @"Giacomo: Allora, stavolta mi è proprio venuta una grande bella idea: e se rappresentassimo il Cyrano de Bergerac? 
Aldo: Ma Giacomino, Giacomino, sempre con queste americanate, finiscila, va! 
Giacomo: Americanate che cosa?! È francese, il Cyrano! 
Aldo: C'hai sempre ragione tu...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 48,
                column: "Content",
                value: @"Giacomo: C'ho un turno di doppiaggio, Aldo. 
Giovanni: Cosa, devi scoreggiare mentre passa un treno? 
Giacomo: Ha parlato il mimetto Tutankamon. Perché non ci vai te allora? 
Giovanni: Che problema c'è? 
Giacomo: Eh, vai! 
Aldo [triste per ciò che stava per succedere]: Giovanni, fallo tu, ti prego... [Giovanni si rassegna] Grazie! [lo bacia]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 49,
                column: "Content",
                value: @"Giacomo: Va' che non ci vuole niente a scaricare le donne degli altri. L'unica cosa veramente importante è che non la lasci parlare: non deve avere il tempo di parlare. Devi essere lucido, freddo, distaccato. 
Giovanni: Tipo Zoff? 
Giacomo: Mmh, tipo Zoff.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 50,
                column: "Content",
                value: @"[Pensando a una terza persona per la cena]
Giacomo: Che poi, non è proprio doppia coppia doppia coppia, eh.
Aldo: In che senso?
Giacomo: Nel senso che c'è una loro amica che si è appena trasferita lì, non ho capito bene... Cioè, bisogna trovare un terzo amico per lei, se no non se ne fa niente...
Aldo: E che problema c'è? Giovanni... mi passi il formaggio, per favore? Ci sarebbe Lello.
Giacomo: Lello? Lello è pesante, dai! 
Aldo: Beh, un po' pensante è vero... 
Giacomo: Logorroico. 
Aldo: Eh, sarà pure logorroico ma parla troppo. Allora Brio. 
Giacomo: Brio potrebbe andar bene... se si lavasse!
Aldo: No, non gli puoi chiedere una cosa del genere a Brio! Allora Rudy!
Giacomo: Rudy? Quello che frega le autoradio?
Aldo: Non quel Rudy lì, l'altro...
Giacomo: Non starai parlando di quello che fa la gara di rutti?!
Aldo: Il due volte campione italiano di rutti!
Giacomo: Cioè, portiam fuori uno che fa i rutti?! 
Aldo: Conosciamo un vip, buttiamolo via!
Giacomo: Vabbè, ho già capito che di questa roba non se ne fa niente... 
Aldo: Ma che cretino! Uno c'ha la soluzione davanti agli occhi e non se ne avvede! Giovanni... non è che conosci qualcuno? Un amico? Un parente?
Giovanni: Non conosco nessuno! [sbattendo il tovagliolo sul tavolo]
Aldo: Neanche un primate col pollice opponibile?
Giovanni: Ma va a cagare, va!
Giacomo: Ma dai Giova, era uno scherzo!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 51,
                column: "Content",
                value: @"[Parlando della cena a tre, al supermercato]
Giovanni: Allora, io... venire vengo perché ormai ho promesso, giusto? Però qualcuno ha visto la ragazza? Non è che mi capita la solita pantegana?
Aldo: Allora, ti capita quello che ti deve capitare, la pantegana o il cane-lupo che sia, comunque stiamo facendo un favore a Giacomino.
Giovanni: E facciamogli 'sto favore...
Aldo: E facciamogli 'sto favore, e non se ne parla più! Allora, torniamo a noi. Giacomino comunque, puoi leggere tutti i libri che vuoi, cosa che mi guardo bene dal fare...
Giacomo: Vantati, eh...
Aldo: Comunque Marco Ferradini è un tuttologo sull'amore.
Giovanni: Allora, fatemi capire bene. La cena la facciamo per Giacomino, giusto? Quindi paga lui?
Aldo: No! Ognuno mette il suo, braccino corto!
Giovanni: Vabbè, io la mia parte l'ho già messa.
Giacomo: Messo cosa?
Giovanni: Le cinquecento lire del carrello!
Giacomo: Va be' ma poi te le riprendi!
Giovanni: Intanto lì è un capitale immobilizzato, e gli interessi, pemm, si impennano!
Giacomo: Interessi cosa?
Giovanni: Lascia perdere, cosa ne sai tu di economia, Giacomo?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 52,
                column: "Content",
                value: @"Aldo: Continuiamo, va'. Fuori dal letto...? Fuori dal letto? 
Giacomo: Nessuno è perfetto. 
Aldo [urlando]: Nessuna pietà! Nessuna pietà! Ma come devo fare con te? Attitudini sull'amore nessuna! [mentre camminano per i reparti di un supermercato, Aldo cerca di spiegare a Giacomo come deve trattare una donna seguendo una nota canzone di Marco Ferradini, di cui Giacomo non riesce a ricordare le parole]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 53,
                column: "Content",
                value: @"Marina: Giovanni, non senti uno strano odore?
Giovanni: Di cosa?
Marina: Di bruciato?
Giovanni: Ah sì è vero, c'è l'arrosto nel forno.
Aldo: Lo sento pure io. 
Silvana: No no, io non sento proprio odore di bruciato. 
Aldo: Eh, c'avrai le mucose andate...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 54,
                column: "Content",
                value: @"Beppe il ladro: Dammi il portafoglio!
Aldo: Ok, ma non mi puntare l'arma addosso.
Beppe il ladro [prende e apre il portafoglio]: Ma è vuoto?!
Aldo: Eh, tu il portafoglio mi hai chiesto...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 55,
                column: "Content",
                value: @"Giacomo: Smettila di buttarti giù, quante volte te lo devo dire, vedrai che va tutto a posto! Del resto tu sei un ragazzo intelligente, eh, si vede! 
Beppe: Da cosa? 
Giacomo: Beppe, son frasi fatte, è per dire... Non è che devi star lì ad approfondire tutto...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 56,
                column: "Content",
                value: @"Giovanni Ciao Beppe! 
Beppe: Magari ci sentiamo... 
Giovanni: Ma sì, figurati! 
Beppe: Allora buonanotte, eh, ciao. 
Giovanni: Buonanotte... [ferma Beppe che se ne stava andando con la sua bici] Ciccio! Eh, eh! La bicicletta! 
Beppe: Aah... 
Giovanni: Eh, ""aah""... E intanto, eh, track! Ti ci sei affezionato! Ecco, Beppe, cerca di perdere il vizio, eh!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 57,
                column: "Content",
                value: @"Giacomo: Giovanni guarda, non so proprio come dirtelo, ma i mobili di tua madre fan veramente cagare. 
Giovanni: Ma cosa ne vuoi capire tu Giacomo, non sai neanche cos'è una pialla! 
Giacomo: Ma cosa c'entra? Non è che uno deve costruire i mobili per saperli apprezzare! 
Giovanni: Eh no, caro! Chi sa fare, sa capire! 
Giacomo: Ma che cazzo di proverbio è? 
Giovanni: Non è un proverbio, è la vita, Giacomo.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 58,
                column: "Content",
                value: @"Giacomo: Abbiamo incontrato Francesca che piangeva! Cosa le hai fatto? 
Aldo: Niente! 
Giacomo: Senti furbino, non è che per caso ti sei messo anche con lei? 
Aldo: No! 
Giacomo: Di' la verità! 
Aldo: Sì... 
Giovanni: Scommetto che ti ha beccato con un'altra eh? 
Aldo: No! 
Giovanni: Di' la verità! 
Aldo: Sì...
Giacomo: Certo che tu sei veramente il campione olimpico dei minchioni!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 59,
                column: "Content",
                value: @"Giacomo: Be', immagino Elena che tu abbia già avuto esperienze teatrali...
Candidata attrice: Io sì. E voi?
[I tre si guardano imbarazzati]
Giacomo: Comunque la commedia sarebbe il Cyrano di Bergerac.
Aldo: Sì, Bergerac... Che sarebbe anche l'autore. [la candidata se ne va]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 60,
                column: "Content",
                value: @"Giacomo: Immagino che tu abbia già avuto esperienze di teatro... 
Candidata attrice: Be', sì... ho lavorato con Albertazzi... 
Aldo: Però... Albertazzi... il grande Albertazzi... il grande e irreprensibile Albertazzi! Mammamia, non sapevo che facesse anche teatro. [la candidata se ne va]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 61,
                column: "Content",
                value: @"Giacomo: Certo che è una situazione kafkiana... 
Aldo: Ma, precisamente, questo Kafkian, chi è?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 62,
                column: "Content",
                value: @"Giovanni [al venditore di snack sul treno]: Che tipo di panini avete? 
Venditore: Abbiamo prosciutto, formaggio, prosciutto e formaggio... 
Giovanni: Prosciutto cotto o crudo? 
Venditore: Cotto. 
Giovanni: No, non mi piace... e formaggio? 
Venditore: Formaggio. 
Giovanni: Ho capito, ci son tanti tipi di formaggio: stagionato, molle, filante... 
Venditore: Senta, io stamattina mi sono alzato alle sei. 
Giovanni: Eh, e io alle cinque! 
Venditore: Sì. A che ora è andato a letto? 
Giovanni: Non so, sarà stato undici e mezza, mezzanotte...
Venditore: Alle due. 
Giovanni: Ah be' allora... formaggio! Mi scusi. 
Venditore: Bravo. 
Giovanni: Me lo può scaldare per favore?
Venditore: Certo. [prende il panino e lo mette contro il finestrino su cui batte il sole] Se ha una mezz'oretta...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 63,
                column: "Content",
                value: @"Giovanni: Io ero a Francoforte, e tu l'hai baciata!? 
Giacomo: Sì... ma Giovanni... 
Giovanni: Stai zitto! Io ero a Francoforte, e tu l'hai baciata!? Mi fai schifo, Giacomo! 
Giacomo: Ma Giovanni, posso spiegare... 
Giovanni: Ma spiegare che cosa? Sei veramente un bastardo, Giacomo! Non ti voglio più vedere! Per me non esisti più! 
Aldo: Ma dai, Giovanni! È solo un bacio... 
Giovanni: Qualcuno t'ha chiesto qualcosa? 
Aldo [si giustifica perplesso]: No... un bacio... è solo un apostrofo rosa fra le parole franco e forte! 
Giovanni: Ma che cazzo stai dicendo? Mi prendi anche per il culo? 
Aldo: Sono confuso, scusa... 
Giovanni: E poi tu lo sapevi e non mi hai detto niente? 
Aldo: No, io non lo sapevo... 
Giovanni [sempre più arrabbiato]: Anzi peggio: tu mi hai mandato a Francoforte per lasciare lui [spingendo la testa di Giacomo] da solo!!! 
Aldo: Guarda, stai creando un equivoco, sei arrabbiato... 
Giovanni: Guarda, mi fai schifo, anzi fate schifo tutti e due... 
Aldo: Ti prego, cerca di ragionare... 
Giovanni: Ma stai zitto, taci! Per favore, taci, taci!! Tu sei capace solo di vivere sulle spalle della gente! Tu sei un approfittatore! Sei un parassita! [alza il tono di voce, mentre Aldo abbassa lo sguardo] Anzi, sai cosa ti dico adesso? Tu vai al mio magazzino, prendi la tua roba e non ti fai più vedere! Hai capito? La pacchia è finita!! Chiaro?! 
Aldo [tenendo basso lo sguardo]: E la commedia? 
Giovanni: La commedia?! Guarda la tua commedia, guarda... [prende una spada di legno e comincia a distruggere tutta la scenografia con rabbia] Eccola! Guarda la tua commedia! La commedia del cazzo!!! [butta giù un albero della scenografia e se ne va]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 64,
                column: "Content",
                value: @"Giacomo: Giovanni, ma sono fasi del rapporto queste qua. 
Giovanni: Sì, fasi del rapporto... 
Giacomo: Giovanni, sono cose che si dicono.
Giovanni: Eh, cose che si dicono...
Giacomo: Senti Giovanni, però, non c'è bisogno di ripetere tutto quello che ti dico, il dialogo è fatto di botta e risposta!
Giovanni: Eh si, botta e risposta... Botta e risposta... 
Aldo: Giacomino, anche tu, sei bravissimo a scarricare, ma per riconciliare una coppia sei una merda proprio!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 65,
                column: "Content",
                value: @"Zia di Aldo: Spero solo di sentire presto gli zoccoli del cavallo di San Bartolomeo. 
Giacomo e Giovanni: Eh, sì... 
Zia di Aldo: Che venga a pigghiasselo col suo sacco nero! Così smette di soffrire! 
Giacomo e Giovanni: Signora, un po' di ottimismo, però!
Zia di Aldo: E questo ottimismo è! 
Giovanni: Ah questo è ottimismo? Chissà il resto...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 66,
                column: "Content",
                value: @"John: Che stai facendo, Jack? Che stai facendo?
Jack: Johnny... Smarties contro Anfetamine, no? [si vedono appunto degli Smarties e delle pasticche di anfetamine disposti su una scacchiera]
John: E ti sembra il momento?
Jack: È sempre il momento!
John [esegue alcune mosse per far concludere la partita]: Partita finita.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 67,
                column: "Content",
                value: @"Al [vedendo ridere John e Jack]: Che c'è da ridere?
John: Niente, Al...
Al: E fate ridere un po' anche me!
John: No, è che... tuo fratello, no?
Al: Che c'hai da dire su mio fratello, parla.
John: Niente, così, dico che... A conoscerlo superficialmente... Tuo fratello è un po'... Eh? [si scambia uno sguardo d'intesa con Jack e ride]
Al: È un po' cosa? Parla!
John: Niente, dai, lasciamo perdere, non parliamone più.
Al: No, parliamone, parliamone, stiamo parlando di mio fratello e parliamone, giusto?
Jack: Allora Al, ti sta dicendo che... Tuo fratello... Ti sta dicendo che tuo fratello... è un ricchione!
Al: Mio fratello non è un ricchione! È raffinato!
Jack: Cos'è tuo fratello?
Al: Raffinato! E comunque stiamo facendo un lavoro, facciamolo e basta, va bene? C'è da ammazzare qualcuno? Ammazziamolo e basta!
Jack: Mii, che clima... E come si fa ad ammazzare la gente con questo clima? Che siamo, delle macchine?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 68,
                column: "Content",
                value: @"Al: Johnny, vai dritto verso la discarica.
Frankie: No, la discarica no! Lo so che cosa succede alla discarica!
John: E che cosa succede alla discarica, Frankie? Che si butta la spazzatura!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 69,
                column: "Content",
                value: @"John: E vabbè va', oggi mi sento di buon umore. Frankie, se risponderai a una domandina facile facile, te ne torni a casa dai tuoi bambini, eh?
Frankie: Grazie Johnny, ti dico tutto quello che vuoi sapere.
John: Ecco, allora dimmi: qual è la capitale della Birmania?
Frankie [stupito]: Ma... come... la...
John: La capitale della Birmania, Frankie!
Frankie: Ragazzi, ma perché fate così, come faccio a sapere la capitale della Birmania?
John: Ahi, ahi, ahi, che peccato, che peccato, che peccato, Frankie! Tra l'altro potevi dire una cosa qualsiasi che a noi andava bene! Chi minchia la sa la capitale della Birmania, Frankie?!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 70,
                column: "Content",
                value: @"Al: ...Ooh, non sai quale cosa si può fare, Johnny...? ...Non lo possiamo mandare a casa? [Frankie Culo di gomma]
John: Le regole sono regole, Al.
Jack: E c'ha ragione, Johnny, che mondo sarebbe senza le regole, eh?
Johnny: Poi anche volendo, come facciamo col boss? Quello vuole il suo cuore su un piatto d'argento.
Al: E che problema c'è? Ammazziamo un cerbiatto e gli portiamo il suo cuore al boss. ...non avete visto Biancaneve e i sette nani?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 71,
                column: "Content",
                value: @"[Dopo aver ucciso il presunto Frankie Culo di gomma]
John: Scusa Al, ma... non avevi detto che volevi salvargli la vita?
Al: Sì, Johnny... E dove minchia lo troviamo un cerbiatto a New York?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 72,
                column: "Content",
                value: @"John: Allora, vediamo domani. Ore 4: far saltare la tintoria dei Jefferson. E mi raccomando Jack, non come l'altra volta che ti sei dimenticato il numero e hai fatto saltare un negozio a caso!
Jack: Sì, però poi era quello giusto!
John: Quella è fortuna, non si lavora così, siamo professionisti!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 73,
                column: "Content",
                value: @"Al: Ti sento, Diavolo, che sei in questa casa! Entra in me! Entra in me, Diavolo! Satana di un satanasso! Io ti scaccio-da questa-casa-male-detta!! Io ti posso affrontare! Hai capito?! Vai via, Satana!!
John: Che minchia sta succedendo, Jack?
Jack: Minchia, Johnny, mi sto ammazzando dalle risate!
Al: Rientra nelle tenebre! Entra in me! Entra in me!
John: Ma che gli hai fatto, Jack?
Jack: Ma niente, Johnny, si è addormentato, poi quando s'è svegliato gli ho fatto credere di essere un esorcista! Ah ah ah!
Al: So che sei qua!! Non mi fai paura!! Abbandona!! Rientra!!! Nelle!!! Tenebre!!!
John: Ma sei impazzito??
Jack: Mi sto ammazzando dalle risate, Johnny! Che bella vita che facciamo, Johnny! Guarda che ridere fa bene! E poi, oh, il bello deve ancora avvenire, eheheheh! [silenzio. Al guarda John in modo strano credendo che fosse il Diavolo]
Jack [sottovoce a John]: E credici un pochino...
Al: Diavolo, ti ho trovato finalmente. Esci da questo corpo deforme. Entra in me. Cosa sei...? Entra in me! Abbandona questo grottesco involucro ed entra in me! Entra in me, adesso...! [John lo colpisce sul naso con il calcio della pistola e lo fa cadere per terra privo di sensi]
John: Come faccio con te, Jack? Come faccio?
Jack: E che ne so, Johnny...
John: Due ore di lavoro buttate via! Quante volte te l'ho detto? Non è un giocattolo, non è un giocattolo!
Jack: Ma mi annoio, Johnny!
John: Jack! Jack! Jack!
Jack: Comunque faceva ridere, di' la verità!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 74,
                column: "Content",
                value: @"Jack: Ma come facevi a sapere che mi piaceva proprio la pistola? 
Al: Eh, tu tre gusti hai! La pistola, le anfetamine e la torta di Melissa.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 75,
                column: "Content",
                value: @"John: Jack, quante volte te lo devo dire, non si spara ai cani! 
Jack: E perché? 
John: Perché sono animali superiori! 
Jack: E chi l'ha detto? 
John: Ma la scienza lo dice, Jack, la scienza! 
Jack: La scienza? 
John: Ma che ne sai tu di scienza!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 76,
                column: "Content",
                value: @"John: [Jack spara alcuni colpi in aria per la casa] Ma che fai, Jack? Che fai? 
Jack: Johnny, ho guardato il libro di Carabbaggio? E lasciami provare 'sta pistola! [Continua a sparare e cade un quadro] 
John: Minchia, quante volte ti ho detto che non si spara in casa, Jack? Quante? 
Jack: Cinque? 
John: No, sette! 
Jack: Minchia, non mi sta in testa...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 77,
                column: "Content",
                value: @"John: [La zia di San Genovese muore uccisa davanti ai suoi occhi, e girandosi guarda Jack che è sotto shock] Ma Jack, che hai fatto? 
Jack: Ma Johnny, non ho fatto niente, ho solo fatto così! [Alza le braccia e dalla cinta parte un colpo di pistola che uccide un autista di bus] MARIA! 
John: Jack, ma quante volte ti ho detto di non tenere la canna della pistola verso l'alto? Quante? 
Jack: Cinque! 
John: No, sette! 
Jack: Minchia, non mi sta in testa, Johnny!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 78,
                column: "Content",
                value: @"Al: [Vede Jack che prende una statuetta di ceramica da sopra la TV] Jack, non mettere le tue mani appiccicose dappertutto!! Lascia stare le cose dove stanno, perché sono cose delicate, hai capito? 
Jack: ""Delicate"" queste cacate!? [Riferendosi alla statua che ha in mano] 
Al: Non sono cagate! Quello è un Capodimonte originale, roba ""italiana""! Tu che ne capisci? Costa un mucchio di soldi... Posala dove l'hai trovata!! 
Jack: [Confuso, rimette la statua al suo posto] L'arte, non la capirò mai...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 79,
                column: "Content",
                value: @"Al: Non preoccuparti, io non voglio immischiarmi nelle vostre cose, ti chiedo solo di parlargli e di dirli che non sei innamorato di lui... se è così...
John: Al, fidati, è così!
Al: E chi ha detto il contrario? Ti chiedo solo di parlagli e di dirgli che i suoi sentimenti per te non sono corrisposti... se è così... 0
John: Al, se dici un'altra volta ""se è così"" ti sparo in testa! È così!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 80,
                column: "Content",
                value: @"Jack: Johnny, però non è che te la puoi pigliare sempre con me, eh? E comunque che credi che io non ci abbia pensato? 
John: Pensato! Jack, ma non ti si è ancora chiusa la fontanella, che vuoi pensare?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 81,
                column: "Content",
                value: @"Jack: Johnny, stai calmo, dammi retta, che con la calma si ottiene tutto... allora Al, ascoltami bene, eh, è facile: adesso tu esci da quella finestra, ti arrampichi sul cornicione ed entri nella stanza di Sam Genovese. 
Al: Cornicione, finestra, stanza... questo lo so. 
Jack: Ecco, è un gioco da ragazzi per te, no? Quando sarai entrato dentro la stanza... 
Al: Scusami, Jack, ma perché non entriamo dalla porta come tutti quanti? 
Jack: E Al c'ha ragione! Perché non c'abbiamo pensato? Perché non entriamo direttamente dalla porta? E magari ci presentiamo con dei sandwich, delle birrette, chiamiamo pure una fanfara, suoniamo le trombe, spariamo per aria! E che credi, che se si poteva entrare dalla porta io e lui non ci pensavamo?! Che siamo, due cretini, io e lui?! È arrivato Sherlock Holmes, è arrivato!
John [tira qualche ceffone a Jack per calmarlo]: Calma Jack! Calma!
Jack [calmatosi]: Scusa Johnny...
John [ad Al]: Non possiamo entrare dalla porta perché davanti alla porta ci sono Tom Schiena di Legno e Sam Mani di Merda, hai capito?
Al: Scommetto che quello che gli cadono le cose è Mani di Merda.
Jack: No, quello è Tom Schiena di Legno, per quello non si può chinare.
Al: E perché a quell'altro lo chiamano Sam Mani di Merda?
Jack: Che c'entra? Quello è perché ci puzzano le mani.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 82,
                column: "Content",
                value: @"Al: [Mentre percorre il cornicione rischia di cadere giù ma si riattacca al muro] Gesù... Perché proprio io?
John: Non guardare sotto, Al. Non guardare sotto!
Jack: Stai andando benissimo, Al. Bravo, bravo! [a John] Johnny non ce la faremo mai! Genovese sta per arrivare!
John: Che sono cretino, Jack? Ho bloccato l'ascensore!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 83,
                column: "Content",
                value: @"Al: [È arrivato alla fine del cornicione ma ha paura a saltare sul traliccio dell'insegna dell'albergo] Ho paura, non ce la posso fare!
John: È facile Al, c'è il traliccio, è facile!
Al: Io torno indietro!
Jack: E salta, Al! Che devo fare, ti devo sparare??");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 84,
                column: "Content",
                value: @"John: Non è successo niente, Al, bravo, non è successo niente... 
Al: Mii, non è successo niente? E che doveva succedere, doveva cadere il palazzo?!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 85,
                column: "Content",
                value: @"John: E poi portare in giro per la città la zia di Sam Genovese è un grande onore. 
Jack: Eh, sai che onore! L'anno scorso è toccato a Nick il Demente... 
John [spazientito per il costante parlare di Jack]: Taci Jack, taci e basta! Non ne posso più quando parli! Adesso andiamo a prendere questa vecchia, la portiamo in giro per la città, la facciamo divertire, siamo gentili, siamo deferenti, la portiamo da Tiffany, la portiamo a prendere il tè con le cassatelle, eh? E poi la riportiamo a casa. E alle 5 p.m. cascasse il mondo saremo davanti allo Stardust, ok?! 
Jack: Johnny, mi hai convinto, andiamoci a pigliare sta minchia di vecchia. 
John [su tutte le furie]: Allora, siamo gentili, non diciamo parolacce, non diciamo volgarità e soprattutto [dà due colpi al clacson per la rabbia] non diciamo vecchia! Ok, Jack? Ok?! 
Al: [Ironico] E allora andiamo a prendere questa teenager.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 86,
                column: "Content",
                value: @"John: Forse m'è venuta un'idea... 
Jack: Gazpacho con la cocaina?! [John gli dà uno scappellotto]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 87,
                column: "Content",
                value: @"John: Sei contento?
Jack: Ti sembro scontento, Johnny? Minchia, Carabbaggio... 
John: Caravaggio, Jack! 
Jack: Sii... [ad Al] Oh, comunque Al, grazie per questo regalo che è bellissimo! [la pistola] 
Al: Dai, digli che ti piace! 
Jack [a John, che sembra triste]: Ma sì, Johnny, mi piace! Minchia... [ad Al] Senti, e... i colpi? 
Al: Eh, i colpi! I colpi... pensavo che li prendeva Johnny! 
Jack: Johnny...?! 
Johnny: Eh... io ero indeciso tra i colpi e Caravaggio... 
Jack: E hai scelto il Carabbaggio...?! [John annuisce, e Jack si scandalizza] Che compleanno di merda! [lancia la pistola sul tavolo]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 88,
                column: "Content",
                value: @"Boss: Dovevate ammazzare una spia... e avete ammazzato un barbiere... non so proprio più come fare con voi, ragazzi... due settimane fa avete chiesto il pizzo ai negozi sbagliati... e oggi mi ammazzate un barbiere!! 
Jack: Eh, poi ci sarebbe anche la storia del bourbon... 
Boss: Quale bourbon? 
Jack: Eh quella partita di bourbon che dovevamo consegnare, e invece... ci siamo scolati al party di Billy Piorrea.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 89,
                column: "Content",
                value: @"Boss: Ora lancerò questi dadi, forza, ditemelo un numero! Se uscirà proprio quel numero avrete salva la vita. Avanti, qual è il vostro numero fortunato, eh? 
Jack: Cinquanta! [John tira uno schiaffo a Jack] 
John: Otto, Boss, il nostro numero fortunato è otto. [il Boss lancia i dadi ed escono i numeri quattro e tre. Al, John e Jack rimangono turbati] 
Boss: Quattro e tre... otto... che botta di culo! 
Jack: Ma scusi Boss, ma quattro e tre non... [Jack riceve uno schiaffo da John e un calcio da Al] 
John: Scusi per l'interruzione, boss!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 90,
                column: "Content",
                value: @"Jack: Allora, Al, ascoltami bene: era venerdì. Eravamo al Drive In di Coney Island. Eravamo lì perché il boss...
John: Jack, se inizi sempre dalla fine, questo [riferendosi ad Al] non capisce niente. Bisogna iniziare dall'inizio, lo dice la parola stessa.
Jack: E allora fai una cosa, Al: ascolta il professorone. [indica John e se ne va]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 91,
                column: "Content",
                value: @"Al: Ma... ditemi un'ultima cosa... quello che mi avete raccontato... è tutto inventato?
[John e Jack fanno per replicare, quando una voce fuori campo li interrompe chiamando Al col suo vero nome]
Herbert: Calogero! Calogero!
Jack [stringendo le spalle]: Eh... Al... non proprio tutto tutto...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 92,
                column: "Content",
                value: @"John: Questo è il piano. Tu esci dalla finestra... fai venti metri di cornicione... e arrivi alla scritta dell'hotel. Ti arrampichi sul traliccio, superi l'insegna... e arrivi al cornicione del piano di sopra. Quando arrivi all'ultima finestra... no quella, quell'altra! La forzerai con un coltellino. E ti introdurrai come una faina nella stanza del boss. Una volta nella stanza, ti infilerai nell'armadio.
Al: Quindi io devo stare nell'armadio?
John: Esatto.
Al: Sono allergico alla naftalina?
John: No.
Al: Sono claustrofobico?
John: No.
Al [sorride]: Minchia, Johnny, hai proprio pensato a tutto! Dopodiché, mentre io sono nell'armadio arriverà Genovese.
John: Esatto.
Al: E quello è il momento, esco dall'armadio e lo ammazzo!
John: Non lo devi ammazzare, Al, dobbiamo salvargli la vita!!! Se lo ammazzi, avremmo addosso tutta la Mafia di New York!
Al: Mmmm...! ma com'è che questa cosa non mi entra in testa? Salvare la vita, salvare la vita, salvare la vita! È così semplice!
John: Allora Al, quando arriverà Genovese, tu non ti devi muovere, devi solo stare fermo ad aspettare! A un certo punto lui ordinerà la cena! Ed è lì che entriamo in scena noi, io e Jack! 
Al: E come facciamo a sapere che Genovese ordinerà la cena? 
Jack: Mii, Al, sono tre anni che facciamo la scorta a Genovese, tutte le volte la stessa storia! Alle sette ordina il pollo fritto, alle otto arriva la buttana, alle otto e cinque siamo tutti in macchina. [Jack fiata] Al, ascoltami bene... quando Genovese ordinerà 'sto pollo fritto, io e Johnny gli prepareremo una sorpresa che quello se la ricorda per tutta la vita! Scenderemo in cucina e con una scusa distrarremo il cameriere, al posto del pollo ci facciamo trovare una bella pistola! È un gioco da ragazzi, no?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 93,
                column: "Content",
                value: @"Jack [rivolto a Johnny, fermatosi in mezzo alla strada in macchina]: Che succede, Johnny? Perché ci siamo fermati?
John: Ho bisogno... di riflettere, Jack! 
Jack: E su che minchia devi riflettere?
John: È finita la benzina!
Jack: E facciamola!
John: La benzina non si fa Jack, la benzina si compra!
Jack: E prendiamo i soldi e la andiamo a comperare! 
John: Quali soldi, Jack?
Jack: Perché, i soldi del Boss e dello smemorato [Al] te li sei già bevuti? 
John: IO!? [Tirando fuori un portagioie in oro] Se tu non ti compravi questo portagioie di Luigi XVI, avremmo ancora un po' di soldi!! 
Jack: Johnny, secondo te dove le ficco le anfetamine, eh? È colpa mia se sono un uomo con un certo gusto, che ha un certo savoir-faire? E comunque Johnny, tu te ne devi stare proprio zitto, sai? C'era bisogno di comprarsi un orso polare da mettere sopra il volante [Indica il volante ricoperto di pelliccia]? 
John: Ma che dici, Jack? Questa è tutta immagine! Serve per lavorare! Che ne sai tu? Che ne sai? 
Jack: Si comunque Johnny, non litighiamo per queste cagate. Ti ricordi che cosa diceva nostro padre? ""I soldi sono fatti per essere scialacquati. E quindi, boys, scialacquate! Scialacqua!""
John: Jack, non abbiamo mai avuto un padre...
Jack: Però sarebbe stato bello ricevere un'educazione così, vero Johnny?
John: [annuisce] Sarebbe stato bello...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 94,
                column: "Content",
                value: @"Aldo: Buongiorno! Dove andiamo di bello? 
Passeggero: Piazza Wagner. 
Aldo: Wagner, complimenti! Wagner! Il grande e irreprensibile Wagner! Compositore austriaco recentemente scomparso, autore del Lohengrin, opera che più o meno fa così... [inizia a intonare una melodia] 
Passeggero: Senta... A parte che è il Bolero di Ravel, e poi ho una certa fretta: piazza Wagner, al 27. 
Aldo: Ah! Questo è il Bolero?! Questo è il Bolero?! Vabbe'... Un attimo che impostiamo il navigatore, perché un conto è chi è Wagner e un conto è dov'è Wagner! ... Wagner si scrive con la G di Goethe?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 95,
                column: "Content",
                value: @"Claudia: Senti, ma perché stasera non andiamo a mangiare fuori? Una cosa semplice eh, una pizza. 
Giovanni [guardando Passaparola in TV]: Eh... Si boh... Dopo vediamo. Passaparola! 
Claudia: Magari un cinemino! È tanto che non ci andiamo! 
Giovanni: Sì... Magari... Mi son già tolto le scarpe... 
Claudia: O sennò restiamo anche a casa... 
Giovanni: Eh! 
Claudia: Tranquilli... 
Giovanni: Ma sì... 
Claudia: Ma sì, infatti, stiamo a casa. 
Giovanni [contento]: Dai!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 96,
                column: "Content",
                value: @"Claudia: Ma scusa, non guardi Passaparola? C'è la ruota finale... [Giovanni la interrompe] 
Giovanni: Ma chi se ne frega di Passaparola! Lo sto registrando!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 97,
                column: "Content",
                value: @"Giovanni [dopo che Claudia chiude una chiamata]: Chi cazzo era a quest'ora? 
Claudia: Che ne so, uno che ha sbagliato. 
Giovanni: Uno che ha sbagliato alle due di notte? 
Claudia: Giovanni, non è che dopo le due di notte non si può sbagliare... 
Giovanni: Sì ma io voglio sapere chi ha sbagliato...
Claudia [perde la pazienza]: Senti: è tardi, sono stanca e non ne voglio parlare! Lasciami dormire. Buonanotte.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 98,
                column: "Content",
                value: @"Claudia: Ma ti rendi conto che [si riferisce a Giovanni] è stronzo!? Io mi spacco la testa per cercare di salvare 'sto cazzo di matrimonio e lui cosa fa??? Che pezzo di merda...
Luciana: E tutte le belle cazzate che avete fatto ultimamente, anche quelle per salvare il matrimonio? Claudia, sono mesi che dici che sei stanca, che dici che sei confusa, che lo vuoi lasciare...
Claudia [inizia a piangere]: Allora vuol dire che deve finire così... [si asciuga una lacrima con la mano]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 99,
                column: "Content",
                value: @"Giovanni: E allora sai cosa faccio? Adesso vado lì, e a questa domanda deve rispondere: o lui o me. Capito? 
Giacomo: A parte che tecnicamente non sarebbe una domanda... Comunque, ho capito.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 100,
                column: "Content",
                value: @"Aldo: Allora com'è andata ieri notte?
Giovanni: Mah, niente.
Aldo: È andata male?
Giovanni: Ma no, il discorso non è andata bene o andata male...
Aldo: Insomma, dovete ancora... discutere?
Giovanni: Ma no, il discorso non è discutere...
Aldo [perde la pazienza]: 'Mariiia, mi stai facendo venire l'herpes! Che cosa vi siete detti? Che è successo???
Giovanni: Se n'è andata, è finita!
Aldo [prima esulta e Giovanni lo squadra di colpo]: No, niente. Mi è arrivato un SMS che aspettavo...
Giovanni: Solo che adesso cosa faccio, eh? Cosa faccio?
Aldo: Ma sì! Ma che vuoi fare? È la vita, dai! Oggi a te e domani a me, la cosa gira. Felice tu, felice un altro.
Giovanni [sarcastico]: Grazie! Sto già meglio!
Aldo: Mi sono spiegato male... E adesso lei dov'è?
Giovanni: Eh... Eh, dov'è... Lo so io dov'è: è insieme a quel bastardo, ecco dov'è!
Aldo [si preoccupa]: Quale bastardo?
Giovanni: Ma perché, non ti ha detto niente il tuo amico?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 101,
                column: "Content",
                value: @"Navigatore: Percorrere questa strada per settecentonovantanove chilometri. [passa un minuto] Percorrere questa strada per settecentonovantotto chilometri.
Giacomo: Ma questo navigatore è proprio indispensabile? 
Aldo: Metti che poi sbagliamo strada. 
Giovanni: Ma siamo in autostrada, è sempre dritto! Come cazzo fai a sbagliar strada? 
Aldo: Vabbe', non lo so spegnere, contento?! Lo so accendere ma non lo so spegnere. Si spegne solo quando si arriva, è concepito così! Qualche problema?! 
Giacomo [sarcastico]: ...Che bel clima. 
Giovanni: Che poi voglio proprio vedere... Me lo deve dire in faccia che il nostro matrimonio è finito per colpa [indicando Aldo] di un tassista terrone e dislessico! 
Aldo: Ti comunico che il terrone apoplettico... 
Giovanni: Dislessico! 
Aldo: Mmmmhhh, come preferisci! Comunque il suddetto terrone dislessico, in due mesi di frequentazione è riuscito a ridargli una voglia di vivere, a Claudia, che tu nemmeno se vivrai con lei diciotto secoli riuscirai a darle, va bene? E comunque se te lo vuoi sentir dire in faccia quanto sei noioso, tra settecentonovantotto km sarai servito. 
Navigatore: Percorrere questa strada per settecentonovantasette chilometri. 
Aldo: Novantasette! 
Giovanni: Che poi io, al limite, una sbandata per un tamarro come te sono anche disposto a capirla. Son quelle cose nella vita che devi fare per forza... Che poi però riponi nel cassetto ""cazzate dell'esistenza"", dove tu abiti tra l'altro. Ed è finita lì... Ma con questo qui dietro [indicando Giacomo]... Ma cosa cazzo mai ci avrà trovato? Cosa ci avrà visto in questo qua? Mi è inconcepibile! Non riesco a capirlo proprio! È una cosa al di là! Que... Cioè... ""Onde del destino""... Ma vai a cagare... 
Giacomo: Forse perché io riuscivo a farla parlare, eh? Perché se non te ne sei mai accorto caro mio, le donne han bisogno di parlare... Ma non solo loro, è proprio l'essere umano in se stesso è fatto di linguaggio, se non c'è la parola, tra gli esseri umani, la comunicazione, cioè è... [vedendo che Aldo al suo discorso sbadiglia] E vabbe'... 
Aldo: Bravo Giacomino, bravo! Parla, parla! Ma dopo tutto quel gran parlare, una donna deve estrinsecare la sua femminilità selvaggia... E allora... 
Giovanni: E allora cosa? 
Aldo: E allora... 
Giovanni: Hai detto allora, e allora cosa? 
Aldo: Quando una donna... 
Giovanni: No, non mi interessa quando, mi interessa allora! Hai lasciato allora coi puntini, riempili! 
Aldo: Giovanni, non è che posso riempirli tutti io i puntini. Penso di averne già riempiti abbastanza... 
Giacomo: Se posso dire... [Giovanni lo interrompe furioso] 
Giovanni [gridando]: Stai zitto! Tu devi stare zitto! Punto!
Aldo: Vuoi che ti riempia anche quello? Di puntino?
[Passa qualche ora e si fa notte]
Navigatore: Percorrere questa strada per 455 chilometri.
Giovanni [vedendo Aldo con gli abbiocchi]: Ohi! Ohi! Ohi! Vuoi che guidi io?
Aldo: Piuttosto che far guidare a un altro mi ammazzo.
Giovanni: Allora se magari prima mi fai scendere...
Aldo: Vabbè... Visto che non c'è il fisico ci fermiamo a dormire.Conosco un posto qui vicino.
Giovanni[vede ancora Aldo con gli abbiocchi]: Ma allora! [più tardi vede che si fermano in mezzo alla strada] Ma sei scemo? Ma spiegami perché non possiamo andare in un albergo! 
Aldo: Regola numero quattro: il taxi non si abbandona mai, cascasse il mondo, piuttosto mi faccio ammazzare a testate! E comunque, se vuoi un alberghetto usi le tue gambette da rannocchietto gracile e cammini, va bene?
Giacomo: Già ben capito come va a finire: si pernotta in un albergo a quattro stelle, servizio in camera... e anche la compagnia non è male, va. [a Giovanni] Dai ciccio, datti da fare!
Giovanni[ad Aldo]: E tra l'altro, questa macchina di merda qua ma chi vuoi che te la ciuli? 
Aldo: Dicevi così anche di tua moglie.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 102,
                column: "Content",
                value: @"Navigatore: Tra cinquecento metri svoltare a destra. Tra quattrocento metri svolt...
Aldo [dopo averlo preso a pugni]: Taci, zoccola! [a Giovanni] Complimenti per la scelta della casa, eh? Comoda! Sono due anni che siamo in giro e mancano ancora seimila chilometri. E poi come fai ad esser così sicuro che Claudia è al mare?
Giovanni: Ha preso le chiavi.
Aldo: Magari erano le chiavi del solaio.
Giacomo: Eh beh sì, magari è lì in solaio che riflette.
Giovanni: Ma no, è impossibile: non ce l'abbiamo il solaio. [Aldo lo squadra] Cioè: ce l'abbiamo, però le chiavi ce le ha il vecchio inquilino e quindi... [Aldo lo squadra di nuovo] Oddio... Adesso mi fate venire un dubbio...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 103,
                column: "Content",
                value: @"Giovanni: Sì ma quando cacchio arriva 'sto carro attrezzi?
Giacomo: Eh, devi star calmo però: dopotutto son passate solo... tre ore.
Giovanni [sente il motore del carro attrezzi]: Oahhh!
Vanni Maceria: Su di noi | l'amore è una favola...
Giovanni: Sì, però...
Vanni Maceria: Su di noi | se tu vuoi volare | ti porto lontano | nei campi di grano | a fare l'amore con me.
Giovanni: Ho capito, però sono anche...
Vanni Maceria: Tu dimmi ti amo | e vieni nel grano | nel prato più bello che c'è... Pupo! Pupone! La più grande rocchestarre italiana di tutti i tempi! L'eroe di Ponticino, deh!
Giovanni: Si ho capito, ma son tre ore e mezza che la stiamo aspettando!
Vanni Maceria: Oh scusate eh, bimbi... è alta stagione esagerata! È già un miracolo che sia arrivato qui io!
Giacomo: Botta di culo, eh?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 104,
                column: "Content",
                value: @"Vanni Maceria: Bimbi, c'ho una bella notizia per voi: avete spappolato il carburatore! È tutto ""sgarganato""!
Aldo: Che ha detto?
Giacomo: Carburatore.
Aldo: Ha detto carburatore?
Giovanni e Giacomo: Carburatore, carburatore.
Aldo: Carburatore proprio? Le parole erano queste? [si preoccupa] Ma no! Il carburatore no! E gli volevo bene come un figlio!
Vanni Maceria: Ma per te è Natale con le palle! Perché in mezzo alle palle ci sono io, il regalo: Vanni Maceria, il Brunelleschi dei Carburatori!
Giovanni: Però è simpatico.
Aldo: Senta, signor Brunelleschi dei Carburatori, e quando sarebbe pronta la macchina?
Vanni Maceria: Ar tocco è tutta pronta a modino.
Aldo e Giovanni: Oh, grazie signor Maceria.
Giacomo: Ma che cazzo avete capito? Vuol dire che è pronta domani all'una!
Giovanni: Eh, no... Dottor Maceria, non possiamo aspettare il tocco a modino.
Vanni Maceria: Oh, [indica l'orologio] è alta stagione esagerata! Ma lo sapete come si dice dalle mie parti? «Chi per la fretta caca nell'ortica, spesso il culo gli formica!» [proverbio]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 105,
                column: "Content",
                value: @"Aldo [preoccupato]: Che ci faccio qui? Che ci faccio qui?? Che ci faccio qui? Che ci faccio qui, Giacomino?
Giacomo: Ascolta, adesso tu bevi questo bicchiere d'acqua e vedrai che ti rassereni, vai. [Aldo lo beve] Va'... Oah! Hai visto? [Aldo butta dietro il bicchiere riducendolo in mille pezzi] Il bicchiere... Il bicchiere, del servizio buono!
Aldo [perde la pazienza]: Che me ne frega a me del tuo servizio di cristallo di Boemia, Giacomino, non fare il piccolo borghese! Sto impazzendo! Ho anche buttato il telefono nel naviglio... [inizia a piangere] Chissà quante volte m'ha chiamato e non m'ha trovato...
Giacomo [cerca di consolarlo]: Stai calmo. Stai calmo. Adesso ripeti tutto, magari in italiano e senza piangere. Allora: eravate al fast food tu e Claudia...
Aldo [cerca di smettere di piangere]: Eravamo al fast food io e Claudia... [si rilassa] Avevamo appena finito di fare l'amore. E tu, Giacomino, mi insegni che dopo aver fatto l'amore niente è meglio di un Big Mac...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 106,
                column: "Content",
                value: @"Aldo: Ah! Quasi dimenticavo... per la corsa sarebbero tremilaseicento euro.
Giacomo [strabuzza di colpo gli occhi e lo squadra]: Come tremilaseicento euro?!?
Aldo: Ah, gia: cappuccio e brioche... Quelli li offro io... Che vuoi? Sono fatto così. Chiamami scemo... chiamami ""unplugged"", ma sono fatto così...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 107,
                column: "Content",
                value: @"Aldo: [parlando via radio] Primo ufficiale Enterprise, abbiamo informazioni rilevanti dal pianeta sconosciuto. 
Giacomo: L'aria è respirabile, ma i livelli di monossido di carbonio sono sopra i livelli di guardia! 
Aldo: Beh?! Sono io che devo comunicare con Enterprise! Ti ricordo che tu sei solo un robot, uno stupido robot! Mentre io sono un umanoide! Li vedi i gradi? Ti ho progettato io! Sono ingegnere positronico laureato al Cepu!
Giacomo: Sette anni fuori corso!
Aldo: Ma che cavolo di umorismo ti ho impiantato? Guarda che posso spegnerti quando voglio, hai capito? Se solo mi ricordassi dove gli ho messo l'interruttore... [via radio] L'aria è respirabile, anche se... 
Giacomo: Inoltre abbiamo rilevato tracce di acqua, muschi, licheni e batteri, questo significa che siamo in presenza di forme di vita! 
Aldo: Ah, sì, bene! Bravo! Ora sta' a vedere che la creatura è più intelligente del creatore! 
Giacomo: Talvolta! In questo caso è certo! 
Aldo: Guarda che ti smonto e ti rimonto a immagine e somiglianza di un frullatore! E adesso che ti guardo bene, ci guadagni!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 108,
                column: "Content",
                value: @"Aldo: [via radio] Rientriamo alla base per analizzare meglio i dati. Testa di latta [A Giacomo], mettiti qua. [via radio] Mandate pure il raggio teletrasportatore. [Il raggio appare in una posizione sbagliata, alla loro destra.]
Giacomo: Ha progettato lei anche quello?
Aldo: [via radio] Avete sbagliato di poco, ma avete sbagliato! Rimandate il raggio... [Il raggio si sposta ma finisce ancora in un posto sbagliato, questa volta alla loro sinistra.]
Giacomo: Ci dev'essere suo fratello gemello al puntatore.
Aldo: Non è che per caso hai sbagliato tu le coordinate?
Giacomo: Di sicuro la cacata l'ha fatta lui.
Aldo: Aaaah, ma perché parla tanto? [via radio] Avete sbagliato di nuovo ma lasciate il raggio lì dov'è, che ci saltiamo dentro noi... sennò facciamo notte, in inglese fahrenheit!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 109,
                column: "Content",
                value: @"[Giovanni entra in scena affaticato spingendo un'enorme palla, la biosfera] 
Giovanni: [Col fiatone] Sembravo uno stercorario con la pallina, sembravo... 
Aldo: Comandante, ma come mai non è dentro la biosfera? 
Giovanni: Perché l'aria è irrespirabile dentro la mia biosfera! Chi è entrato per ultimo? Eh? Flander! [Giacomo alza le mani per provare la sua innocenza] 
Aldo: Comandante... sono entrato per fare meditazione dopo aver mangiato cavoletti di Bruxelles geneticamente modificati. Mi perdoni... 
Giovanni: Ho avuto un mezzo ictus lì dentro! Se non mi facevo una pera di eroi... di Roiptidanol ci lasciavo le penne!! 
Aldo: Comandante, sono molto costernato... 
Giovanni: Eh, sono costernato, non basta dire sono costernato! Ci vuole una manifestazione concreta di costernazione! [Aldo cerca di essere più dispiaciuto possibile, facendo una faccia triste] Da domani solo riso in bianco, eh? Almeno per un mese! [A Giacomo] Flander, porti al macero la mia biosfera. Purtroppo è irrecuperabile. 
Giacomo: Sarà un piacere prendere a calci questa palla di merda! [Prende a calci la palla di biosfera dietro le quinte]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 110,
                column: "Content",
                value: @"Giovanni: Primo ufficiale, com'è questo pianeta? Ditemi. 
Aldo: Comandante, questo pianeta è inutile e parsimonioso. 
Giacomo: Invece secondo me ci sono interessanti forme di vita che andrebbero analizzate! 
Giovanni: Ma sì, ma la vita l'abbiam trovata dappertutto, muschi, licheni, ragnetti, bruchi, vermini, quelle robe lì fastidiose... 
Aldo: Organismi monocellulari, brodo primordiale... e anche se si evolgono più in là della muffetta non vanno...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 111,
                column: "Content",
                value: @"Giacomo: [Il robot ha detto di aver individuato, tramite il rilevatore puntato verso il pubblico, che le forme vitali presenti sul pianeta si stanno muovendo] Comandante, non si allarmi, non sono ostili! Sono solo molto curiosi!
Giovanni: Ma... c'è dell'intelligenza?
Giacomo: Adesso non esageriamo, comandante! [Puntando il rilevatore verso il pubblico e spostandolo continuamente.] Tracce di intelligenza! Sì... un po' di più... molto meno... no... così così... potrebbe dare di più ma non si impegna... [Lo punta verso Aldo] È scomparso il segnale!
Giovanni: Eh per forza, lo sta puntando verso il primo ufficiale! Non è che possiam pretendere!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 112,
                column: "Content",
                value: @"Giacomo: Comandante, tenterei di stabilire un contatto con queste forme aliene. Potrebbero darci una mano a risalire sull'Enterprise. 
Giovanni: Ci penso io! Mostrerò loro il nostro elevatissimo grado di scienza, tecnologia e cultura! Li stupiremo! [al pubblico] Forme di vita semintelligenti, ditemi, l'uccellino è vivo o morto? Eh?
Irina [Con accento russo]: Eh, nel suo caso è morto, eh comandante!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 113,
                column: "Content",
                value: @"Giacomo: Comandante, muschi e licheni chiedono di parlare con l'interlocutore più qualificato.
Giovanni: Ci vorrebbe un volontario.
Aldo: Comandante, vorrei essere io il volontario.
Giovanni: Siamo spacciati.
Aldo: Comandante, le ricordo che io sono metà vesuviano e metà terrestre.
Giacomo: Avrei detto metà demente! 
Aldo: Ed ho insita in me la capacità di comunicare telepaticamente. 
Giovanni: Ma se deambula che è un miracolo, primo ufficiale!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 115,
                column: "Content",
                value: @"Giacomo: [Spazientito da Aldo che non riesce a prelevare dal bancomat.] Scusi, scusi, ha dei problemi alle mani? Tipo gravi impedimenti motori agli arti superiori? No, perché sono venticinque minuti che digita inutilmente su quella tastiera, suppongo nel vano tentativo di prelevare denaro senza riuscirci. Ce la farà entro Natale? Glielo auguro io e tutta la fila, grazie e buon lavoro!
Silvana: Va be', scusi eh! Stia tranquillo, ci sono prima io davanti, quindi...
Giacomo: Quindi se lei non ha un cazzo da fare è un'altra questione, ha capito? Non è che possiamo star qua tutta la mattina ad aspettare uno che deve fare un prelevamento!
Aldo: Per favore cortesemente, glielo dico cortesemente, eh? Può... andare un passo dietro la linea gialla? Eh? E non starci sopra? E non schiacciare la schiena alla linea gialla, eh? Perché la linea gialla soffre! Perché la linea gialla è un punto di, di, di fermo, non un punto di sovraccarico, ha capito? Non le sto chiedendo chissà che cosa! Voglio dire, è inutile che mi guarda con questi occhi da cernia! Forse perché mi vuole cernire il codice segreto? È per questo che va un passo avanti, eh? Questo... allunga questo collo a brontosauro perché mi vuole cernire il codice segreto? Eh? Eh? Cosa vive lei ancora nel giurassico signora? Guardi stiamo facendo una una cosa di di proprietà privata questa è una stanza non è un cantieeereeee! E non è quest e non mi guardi questa oassessa, uh, ah! 
Giacomo: Signora non faccia gli occhi da cernia e il collo da brontosauro con uno che ha dei problemi motori alle mani e soprattutto, ormai è acclarato, siamo di fronte a un individuo che non sa ne intendere e ne volere, capisce? Se no siamo qua fino alla prossima olimpiade. 
Silvana: Ma guardi che è diventato tutto rosso eh, prende le malattie, sa... Lei deve assorbire tutte le energie benefiche della luna, eh! Apra tutti i suoi chakra!
Giacomo: Glieli aprò io i chakra, adesso!
Aldo: No! Ho sbagliato! Ho sbagliato, è la seconda volta che sbaglio, ora se sbaglio anche la terza volta mi mangia la tessera del bancomat, io sono un uomo finito.
Giacomo. Magari così si leva dalle palle e preleviamo noi.
Aldo: Telefono a casa. 
Giacomo: Telefono a casa?
Aldo: Ma tanto è inutile non ci sarà nessuno adesso... 
Giacomo: Ma porca di quella...
Aldo: Graziella sei a casa? Mamma mia, mi stai salvando la vita, non sai quanto ti sono grato che tu sei a casa in questo momento, Graziella ascolta eee è Graziella, mia suocera, è a casa. 
Giacomo: [Sarcastico] Ce la saluti molto calorosamente. 
Aldo: Ti saluta... lei è?
Giacomo: Giorgio Stramaroni. 
Aldo: Giorgio Stramaroni una persona molto in. Ascolta Graziella dovresti andare in camera di Gaetano, hai presente capitan orsetto, quello che lui ci gioca sempre che parla sempre con lui che per parlare con me parla attraverso di lui, capitan orsetto quello che ci dorme tutte le notti... ce l'hai in mano? Squartalo! Dentro ci deve essere il numero di codice del bancomat! Tira via la paglia, l'hai trovato? Eh, dimmi... cinque, quattro... sette... No!! No, Graziella no! 5-4 è il numero di codice segreto per vedere i porno su Sky! [Guarda Giacomo, imbarazzato] Guardi che lo faccio di lavoro... cioè, che mi frega a me? 
Giacomo: E che lavoro fa?
Aldo: Falegname.... allora Graziella vai in camera di Caterina, [Di nuovo, a Giacomo] Caterina è mia figlia, la femmina. Mamma mia quanto è grande. 
Giacomo: Scusi, quanti figli ha?
Aldo: Sette! 
Giacomo: [A Silvana, sapendo come andrà a finire] Stiamo qua fino alla prossima Olimpiade, glielo dico io... 
Aldo: Allora Graziella, sei in camera di Caterina? Ok allora, davanti all'armadio c'è la sua collezione di Barbie, ok, prendi ""Barbie Baldracca""... Non quella con le calze a rete rotte, quella è ""Barbie Alcolista"", ""Barbie Baldracca"" è quella con la minigonna vertiginosa, c'ha il tatuaggio della farfalla sul gluteo, e sotto l'ombelico c'è il codice... l'hai trovato? Dimmi! 1, 2, Vai piano che non ti seguo... 2 me lo metto qua... 3 me lo metto qui... [indicando varie zone della testa] 
Giacomo: Scommetto che è 4 e 5. 
Aldo: 4 me lo metto qui e 5 me lo metto qua sotto il cervelletto. Ciao, vado se no mi dimentico i numeri, ciao! 
Giacomo: [A Silvana, dopo aver scoperto il codice, ovvero 12345, considerando il tempo che Aldo ha perso per indovinarlo] Una famiglia di geni!! I più famosi criptologi dell'Altitalia!! Che cazzo parlo a fare con lei... 
Aldo: [Comincia a tastarsi i punti della testa dove ha ""salvato"" i numeri, ma li digita lentamente] Allora, il primo è... 1... e poi... 2, 2... [Si sforza, tastandosi la testa] Mii! E l'altro numero dove l'ho messo? L'ho già perso... 
Giacomo: [A gran voce, per incitarlo a muoversi] Minchia... 3!!! Provi col 4, e tentiamo il 5! 
Silvana: Ma scusi lei, eh, ma come faceva a saperlo?
Giacomo: [Sarcastico] Piacere, mago Merlino! 
Silvana: Ma va? 
Giacomo: Vuol vedere la bacchetta magica?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 116,
                column: "Content",
                value: @"Giovanni: Tipo, ce li hai dieci euro? Sai... per i cani... 
Giacomo: [Indicando il bancomat.] Appena riesco a prelevare! 
Giovanni: Grazie... Senti, vuoi che ti faccia un tatuaggio? [Ripete col megafono] Un tatuaggio?? 
Giacomo: No, grazie, fallo a tua sorella il tatuaggio! 
Giovanni: [Sempre col megafono] E un piercing??? 
Giacomo: [Minaccioso.] Se non ti levi ti faccio il clistere, capito?? [Giovanni brontola] 
Silvana: [Parlando dei cani di Giovanni.] Ma che belli che sono, eh? 
Giovanni: Eh sì, sono cani. 
Silvana: Sì, lo so! 
Giacomo: Perché non ne porta a casa due?
Silvana: Eh no, eh, perché non ho il giardino...
Giacomo: Che sfiga...
Giovanni: [Col megafono] Vuoi un roipnoil? Eh?
Silvana: Eh no, eh, perché non ho il giardino...
Giacomo: Ma voi due vi siete conosciuti a San Patrignano? Eh?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 117,
                column: "Content",
                value: @"Silvana: Senta lei, scusi se mi permetto, ma lo sa che non si danno calci ai cani?
Giacomo: Chiedo scusa, la prossima volta li darò a lei.
Silvana: Eh no, eh, perché non ho il giardino...
Giacomo: [Al pubblico] Adesso mi compro una dose di eroina e mi ammazzo! Qui la venderanno, eh... 
Silvana: [Parlando dei cani di Giovanni] Ma che belli... 
Giovanni: [Col megafono] Ti piacciono?? 
Silvana: Scusi, ma io ci sento, eh! 
Giovanni: Brava! 
Giacomo: Una cosa che funziona lì dentro... 
Silvana: Eh no, eh, perché non ho il giardino... 
Giacomo: Che cazzo sarà? Le polveri sottili... cosa sarà?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 120,
                column: "Content",
                value: @"Aldo: Oh, dovreste farmi tutti un favore! Scusate, lì dietro... Allora, dovremmo fare tutti una cosa insieme. Siccome qui c'è una gazza ladra addestrata a portare via i soldi al malcapitato... ed è capitato. Allora, per evitare che questa qui plana, agitiamo tutti le mani, così questa qui si spaventa e non plana. Avanti, facciamolo, dai! Forza, tutti insieme. Agitiamo le mani. [Silvana e Giovanni lo fanno, mentre Giacomo sta con le braccia incrociate.]
Silvana: Senta, scusi, ma agiti le braccia, che cosa le costa?
Giacomo: [Le agita con malavoglia] Tanto la mattina è andata a puttane!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 121,
                column: "Content",
                value: @"Silvana: [Aldo ha finalmente finito di prelevare e Giacomo passa davanti al bancomat.] Scusi eh, forse non si ricorda, ma c'ero prima io davanti a lei!
Giacomo: Ha ragione, ma... incameri l'energia di Nettuno e Plutone, faccia un soffritto ayurvedico, liberi due o tre chakra e si tolga dalle palle! Va bene?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 122,
                column: "Content",
                value: @"[Giovanni e Giacomo parlano dietro le quinte, mentre Aldo compare in scena e osserva un quadro] 
Giacomo: Allora Giovanni, appena entri in questo museo, ti accoglie subito un capolavoro. 
Giovanni: Questo qua? 
Giacomo: Questo è un quadro di Braque... 
Giovanni: Braque? 
Giacomo: Siamo agli inizi del secolo scorso... ah, una particolarità: questo quadro va visto da lontano... [Aldo indietreggia] 
Giovanni: Ma dai? 
Giacomo: Sì si... no, ma non così, veramente lontano. Vai, allontanati! [Aldo si allontana] 
Giovanni: Ancora di più? 
Giacomo: Perché l'artista ha lavorato sulle linee, sulle forme e sui volumi, creando una specie d'illusione ottica... e vuole che tu stia veramente lontano! Vai, vai, arretra! [Aldo si allontana ancora di più] 
Giovanni: Va bene, arretro! 
Giacomo: Quando sei nella giusta posizione, che fai? Apri e chiudi gli occhi fino a quando l'essenza del quadro stesso non ti compare dentro la pupilla, come se fosse un flash, una sorpresa! 
Giovanni: Ah, una sorpresa! [Aldo comincia ad aprire e chiudere gli occhi, facendolo nei modi più bizzarri] 
Giacomo: E questo è un po' ciò che sta alla base del Cubismo... perché questo è un quadro cubista. Poi, l'altra particolarità è che l'artista ha lavorato pressoché con un colore solo, quindi...? 
Giovanni: È monocromatico! 
Giacomo: Bravo! Stai imparando le parole dell'arte! Quindi Cubismo e Monocromatismo. L'artista è Braque, il quale, insieme a Picasso, all'inizio del secolo scorso, ha aperto tutte le porte all'arte moderna che da lì in poi... si sarebbe succeduta... [Lui e Giovanni entrano in scena ed osservano il quadro che stava guardando Aldo] 
Giovanni: Ma và? 
Giacomo: Oh, qui ci troviamo di fronte a tutt'altro stile pittorico. C'è da dire una cosa in maniera preliminare, che questo quadro va visto...? 
Giovanni: Beh, da vicino! 
Giacomo: Perché soltanto un cretino si allontanerebbe per vedere questo quadro! [Aldo si riavvicina al quadro] E questo è un quadro che va visto nella sua giusta distanza... ecco, qual è la prima cosa che ti viene in mente, osservando questo quadro? 
Aldo: Che è monocromatico...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 123,
                column: "Content",
                value: @"Giacomo: [Vedendo Giovanni sedersi su una sedia] Ma sei scemo Giovanni? Sei cretino? Hai rovinato una scultura di Fistalloni!
Giovanni: Non lo sapevo! [Rivolto ad Aldo, scandalizzatosi] Ma se non sai neanche chi è!
Giacomo: Ma scusa, ma questo è il maestro del distrutturalismo!
Giovanni: Eh, mia nonna ne ha a casa due uguali, pensavo che fosse...
Giacomo: Ma Giovanni! Ma questa non è una sedia comune!
Giovanni: No?
Giacomo: Questo è il concetto di sedialità, che il maestro Fistalloni ha voluto rappresentare estrapolando una sedia dal contesto abituale in cui solitamente sta, in una misera cucina, ed elevandola ad universale! Fistalloni!
Aldo: Fistalloni! Eh, ti sei seduto sul concetto di Fistalloni!
Giovanni: A parte che Fistalloni pensavo fosse uno della Lega...
Aldo: Ma che Lega! Fistalloni, insieme a Jocelyn, Gogard... la – la – la corrente del ""distrullarismo""!
Giovanni: Sì, la corrente alternata...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 124,
                column: "Content",
                value: @"Giovanni: Cioè quella lì non è una sedia, e questo è un estintore?
Giacomo: Mi stupisco che tu non colga la differenza tra oggetto e sua rappresentazione, tra realtà e opera d'arte, tra immanenza e trascendenza. Ci sono voluti secoli di dibattito metafisico e ontologico attorno al concetto di rappresentabilità che l'uomo oramai ha introiettato, e superato. Perdonami caro.
Giovanni: Ma vaffanculo! [Tirando un calcio all'estintore vero che credeva essere la rappresentazione di un estintore]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 125,
                column: "Content",
                value: @"Giacomo: Venite... Venite qua... Mettetevi di fianco a questo quadro, che è considerato il capolavoro del museo. Osservatelo bene, dopodiché: che cosa ne dite?
Giovanni: Eh, che qualche deficiente l'ha rovinato con un taglierino! Si vede, porca va... Ha fatto tre sbreghi... È chiaro, non c'è controllo.
Aldo: Poi m'indigno, ci sarà un motivo perché mi indigno? Fanno entrare chiunque, si riempiono le tasche di taglierini, fanno quello che vogliono e noi non facciamo niente.
Giacomo: Posso urlare al mondo la mia indignazione? Posso farlo? Quanta ignoranza!
Giovanni: Bravo! Quanta ignoranza ci vuole per fare una roba del genere, dai! Un minimo di testa...
Aldo: Ma io non capisco... se tu sei ignorante, rimani nella tua ignoranza, rimani nella tua mediocrità! Ma invece sei invidioso, geloso, e vieni qua dove ci sono persone che comunque si vogliono evolgere...
Giovanni: Da che lato? A destra o a sinistra si vogliono evolgere?
Giacomo: Ma ditemi dove sbaglio? Ditemi dove sbaglio! E cosa posso fare!
Giovanni: Ma niente Giacomo, ma tu anzi, cavolo, tu sei bravissimo, sai un sacco di cose, le spieghi... avercene!
Aldo: Ma... Giacomino, esistono i cretini... esistono, giusto? Purtroppo sì, e sono anche molto vicini a noi.
Giacomo: Molto più di quanto non si creda!
Aldo: Più di quanto non si creda, bravo. Tu non ti sottovalutare mai, perché tu sei un diadema di questa società. È grazie a te che il mondo va avanti. È grazie a te che io oggi so qualcosa!
Giovanni: Niente, però questo è un altro discorso.
Giacomo: Ditemi almeno chi l'ha fatto.
Giovanni: Eh, saperlo, vedi che calci nel culo gli davamo, se lo beccavamo mentre lo faceva! 
Aldo: Mica è la prima volta che prendiamo a calci nel culo... 
Giovanni: Oh, abbiamo beccato una volta uno che rigava una macchina. Lui l'ha preso al volo, io da dietro pam, pam!
Aldo: Tre isolati a calci nel culo, prova a chiedergli a quello lì se ha ancora intenzione di rigar le macchine! Non lo fa più! Perché queste cose servono! Ogni tanto servono! Non sempre, però servono.
Giacomo: Lucio Fontana.
Giovanni: Ah, si sa chi è! Ah, l'han beccato. Ah bè meno male, almeno uno, una volta...
Aldo: Allora la giustizia funziona! Dieci anni, gli devono dare. Prendere uno, per prenderne cento. Cioè prenderne uno, prenderne cento. Prenderne uno, per prendere cento. Cioè, voglio dire, ci sono questi cento che camminano a stormo, adesso... voglio dire... fra cretini si ritrovano e camminano tutti così, tutti a stormo così... come, ogni tanto, come gli stormi, proprio... che si allargano, si stringono, camminando. E danno anche fastidio da vedere. Poi c'è qualcuno che è al centro dello stormo, non riesce a respirare, ha bisogno di aria, allora si fa strada fino a che arriva nella zona limitrofa dello stormo e spinge quello che è già lì. Questo qui si perde dal gruppo e viene preso. Quindi prenderne uno, per non prenderne novantanove!
Giovanni: Non credo che fosse così, però...
Giacomo: È nato nel 1906 [In realtà il vero anno di nascita è il 1899] .
Giovanni: Un vecchio! Eccolo lì! Ma porca vacca! Ma lasciali lì a guardare gli scavi in strada, che son contenti! Stan lì: ""E va la ruspa, che la tira su la roba! Li tubi che van lì"" e lì passano il tempo e son contenti. Ma perché li devi far venire qui che non c'han più la testa.
Aldo: Ma io non lo so, se tu sei un vecchio perché sei un tenero, hai bisogno di... No, voglio dire, se tu sei stato un cretino da bambino, sarai un cretino anche da vecchio!
Giovanni: Eh, non indicare però...
Aldo: Se tu nasci torto, Giacomino, muori torto! Se tu nasci dritto... non è detto che muori dritto... puoi anche morire torto. Secondo le... Ma se nasci torto non puoi morire dritto! E non lo dico io, lo dice un greco... Lapalissian, un greco... ma, del, proprio della Grecia.
Giacomo: È nato a Rosario, in Argentina.
Giovanni: Un extra-comunitario! Ma porca vacca! Ma tu li accogli qua e loro se ne fregano delle regole. Non gli interessa nie... A casa loro fai una roba del genere? Ti taglian la mani e vai in giro così! E invece qua puoi far quello che vuoi, perché? Perché nessuno rispetta più le regole, è chiaro.
Aldo: Ma non solo! Perché glielo si lascia fare! Vedi, noi siamo stati immigrati a nostra volta, ma quando siamo andati a casa di queste persone ci siamo comportati in ben altro modo, e abbiamo fatto delle offerte che non potevano rifiutare.
Giacomo: È morto nel 1968. Dopo aver regalato al nostro paese capolavori di inestimabile bellezza esposti nei musei più importanti del mondo, dopo aver inventato lo spazialismo e i famosissimi tagli nelle tele. E voi due siete due bestie. [Ad Aldo.] Tu poi, sei nato torto e morirai testa di cazzo!
Giovanni: È un'aggravante, eh.
Aldo: Tu devi stare solo zitto, perché ti sei seduto anche sul concetto di Fistalloni!
Giovanni: Ma se hai guardato un quadro normale da 3 chilometri?
Aldo: Ha parlato quello che non sbaglia mai... mi fai una rabbia, guarda...
Giovanni: Sì, ma... [Per allacciarsi una scarpa, schiaccia accidentalmente uno sgabello]
Aldo: [Sottovoce] Lo vedi che sei un cretino? Questa è la dimostrazione che sei un cretino! [Giovanni toglie il piede, e lo sgabello rimbalza all'improvviso. Aldo fa in tempo a prenderlo al volo]
Giovanni: [Sottovoce] E' saltato! Hai visto? Saltato per aria... cos'era?
Aldo: Non cercare scuse!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 126,
                column: "Content",
                value: @"[Davanti a una cornice vuota, in cui Giovanni infila la mano]
Giacomo: Cosa tocchi? Cosa tocchi?!
Giovanni: Non c'è niente!
Giacomo: Ma come non c'è niente?!? [con enfasi] È un'opera d'arte...
Giovanni: L'han ciulata...?
Giacomo: Non l'hanno ciulata! Sei di fronte a un capolavoro... di Jean Fofon!
Giovanni: Ah, il francese!
Giacomo: Belga, bestia! Questo è il maestro del coinvolgismo: l'artista ha messo a disposizione il suo spazio vuoto perché vuole che sia tu, fruitore, a riempirlo.
Giovanni: Cioè lui non ha fatto un cazzo, ha detto ""tanto la gente poi ci vede quello che vuole"", e io me ne lavo le mani...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 127,
                column: "Content",
                value: @"[Davanti alla cornice vuota] 
Aldo: Ma questo va visto da vicino o da lontano?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 128,
                column: "Content",
                value: @"[Aldo si è incastrato in una statua, e prova ad attirare l'attenzione di Giovanni e Giacomo] 
Giacomo: Ehi! Vieni via di qua! Vieni via di qua!! Questa è una scultura? Questa è una scultura di Tanguely, vieni via di qua! [Gli schiaffeggia il libretto della guida in testa] 
Aldo: Ahia... 
Giacomo: Ma cosa fai qua dentro? 
Aldo: Eh, sono incastrato, non riesco ad uscire! 
Giacomo: Ma come cazzo fai ad incastrarti in una scultura? 
Aldo: [piangendo] Ma che ne so! Ero qui tranquillo, mi hanno spinto! 
Giacomo: Ma chi ti ha spinto? 
Aldo: Non lo so... ho sentito quattro... [Giacomo gli schiaffeggia il libretto di guida in testa] ahia! 
Giacomo: La tua idiozia ti ha spinto!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 129,
                column: "Content",
                value: @"Giacomo: [Su tutte le furie, riguardo ad Aldo, incastrato in una scultura] Guarda, ti ammazzerei di botte, ti ammazzerei! 
Aldo: [Fa per andarsene con la scultura, girando una ruota montata su di essa come volante] Vabbè, parcheggio e ci mettiamo d'accordo... 
Giacomo: Guarda che l'arte merita [Gli schiaffeggia ripetutamente il libretto di guida in testa] ri-spet-to! Hai capito? 
Aldo: Ma perché te la prendi con me, sono scivolato su una buccia di banana! 
Giovanni: Ma prima avevi detto che ti avevano spinto!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 130,
                column: "Content",
                value: @"Giovanni: Ma sei sce... Ma dove guardavi, hai fatto la puntura a me! 
Giacomo: Ma scusa, ti metti lì davanti! 
Giovanni: Ma non distingui il culo? 
Giacomo: Ma Giovanni, il culo è culo. 
Giovanni: E no, c'è culo e culo: pensa a Dolce e Gabbana!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 131,
                column: "Content",
                value: @"Aldo: Ha visto com'è stata veloce la funzione signora, sono diventato cardinale or ora. 
Signora: Perbacco. 
Aldo: Senta signora, purtroppo devo darle una brutta notizia... In casa sua, mi dispiace dirglielo si annida... nientepopodimeno che il Demonio! 
Signora: Cosa si annida? 
Aldo: Il Demonio si annida quasi sempre nel sifone... 
Signora: Nel sifone, il Demonio?! 
Aldo: Nel sifone sotto il lavandino. Oppure nel water nel caso lei non abbia tirato l'acqua, ma lei ha tirato l'acqua...? 
Signora: Io tiro sempre l'acqua! 
Aldo: Eh, allora è sicuramente nel sifone signora. Signora, parliamoci in maniera papale papale. Dovrebbe far entrare il mio adepto, che è un esorcista della curia di Milano e le stanerà dalla posizione sifonile il Demonio. 
Signora: Senta, ma il suo adepto mi ha appena depto che era qui per la benedizione natalizia. 
Aldo: A Pasqua? 
Signora: Eh! 
Aldo: Le ha detto una cacata. [La signora ha capito della truffa, e Aldo inizia a preoccuparsi]
Signora: Senta, vuole che le passi l'esorcista o l'idraulico? 
Aldo: Mi può passare tutt'e due per cortesia?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 132,
                column: "Content",
                value: @"Giovanni: [Mentre Aldo cerca di rubargli il motorino] Uè, Nino, cosa stai facendo? Uè! Vieni giù dalla moto! Allora! Porca vacca, stavi cercando di rubar la moto, eh? 
Aldo: Sono un collezionista. 
Giovanni: Eh, so io che cosa collezioni tu, va là!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 133,
                column: "Content",
                value: @"Giacomo: Allora, Mozambico? 
Aldo: Sono un collezionista. 
Giacomo: Cosa colleziona, avvisi di garanzia?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 134,
                column: "Content",
                value: @"Giacomo: Con questo lei cosa vorrebbe dire? Che ci sono cittadini di serie A e cittadini di serie B secondo lei?
Giovanni: Mah, se lo guardiamo bene in faccia, lì siamo C2 zona retrocessione!
Giacomo: Ahhh, un razzista!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 135,
                column: "Content",
                value: @"Aldo: Meno male che forse sono italiano! Sono di Gela.
Giovanni: Di Gela... ah di Gela! Ma dai, Gela, profondo sud, l'han chiamata Gela! Ma chiamala in Scandinavia Gela! Profondo sud chiamala Caloria, per dire... per dire la gente che c'è in quel posto lì... Lei mi insegna.. città di baluba sicuro!
Giacomo: Mia mamma è di Gela! 
Giovanni: Io faccio sempre due settimane di vacanze a Gela. 
Giacomo: Caro il mio bel furbino, a Gela non si fanno vacanze, a Gela si lavora e ci si rompe i coglioni, ha capito? 
Giovanni: Infatti un po' tutte e due mi ricordo. 
Giacomo: È sua questa moto? 
Giovanni: Ehm... sì, è mia! 
Giacomo: Questa moto in divieto di sosta è sua? Sono 140 € di contravvenzione! Perché certo il suo scarsissimo senso civico le suggerirà che i marciapiedi sono fatti per farci cagare i cani e dimenticare le moto in divieto di sosta. Complimenti! 140€ di contravvenzione 
Giovanni: No... ero impossibilitato... Ma guarda te!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 138,
                column: "Content",
                value: @"Giacomo: [Giovanni ha dato una lieve botta sulla spalla ad Aldo, che si accascia a terra dolorante] Madagascar! Allora! 
Aldo: Non ci vedo più! 
Giovanni: Ma gli ho dato un colpo qua, cosa c'ha il nervo ottico sulla spalla? 
Giacomo: Lo sa che ci sono delle ripercussioni gravissime?? 
Aldo: Ho preso anche il colpo di frusta!
Giovanni: Sì, ti porto al circo allora col colpo di frusta!
Aldo: Non vedo più niente! Vedo solo puntini! 
Giovanni: Ecco bravo uniscili i puntini, e viene fuori quello che sei: S-t-r-o-n-z-o [Indietreggia perché Giacomo si avvicina minaccioso] 
Giacomo: Guardi... lei si sta mettendo in una brutta situazione ha capito? Abbiamo fatto la revisione di questo motociclo?
Giovanni: Certo!
Giacomo: Eh, ""certo""! Non ne sarei così sicuro, non vedo il bollino blu!
Giovanni: Ma non è mica una banana!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 140,
                column: "Content",
                value: @"Giacomo: [Guarda inorridito le chiavi della moto di Giovanni] Non mi dica che queste...
Giovanni: Sì, son le palle del gatto... le ho fatte mummificare perché c'ero affezionato... Deve vedere il gatto, se le lecca ancora! Fa... [Imita il gatto] poi si accorge che non ci sono e fa una faccia tutta... sto pensando di riattaccargliele per dargli fiducia!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 141,
                column: "Content",
                value: @"Aldo: Ah, senti che aria pulita! Respira a pieni polmoni.
Giovanni: Che vista che c'è, eh! Siamo in alto.
Aldo: Altissimo, altroché.
Giovanni: Senti, ma... quello là è il Duomo di Milano?
Aldo: Pensa che l'aria è così pulita che quello è il Duomo di Pavia.
Giovanni: Ma dai! Quindi quella là dietro non è la montagnetta di San Siro?
Aldo: No, è l'Etna! 
Giovanni: L'Etna! Che tersitudine che c'è oggi!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 142,
                column: "Content",
                value: @"Giovanni: Trenta piani quanto sono in misura?
Aldo: Eh... trenta piani sono cento foot.
Giovanni: Cento foot? E cento foot quanto sono più o meno?
Aldo: Cento foot sono più o meno venti yard.
Giovanni: Venti yard. E in metri non si può misurare? 
Aldo: Se facevamo la staffetta 4x4, misuravamo in metri, siccome stiamo facendo jumping si misura in foot, massimo in yard!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 143,
                column: "Content",
                value: @"Giacomo: [Col fiatone] Ho fatto trenta piani a piedi... 
Giovanni: È dura, eh? 
Giacomo: È dura... porca troia se è dura! Ma perché non mettete l'ascensore? 
Giovanni: Eh, non sono l'amministratore di condominio! 
Giacomo: Ah, non sei tu l'amministratore...? Federico! [È l'unico nome con cui riconosce Giovanni] 
Giovanni: Giovanni! Devi stare a casa! 
Giacomo: Ho capito, ma a casa mi annoiavo... 
Giovanni: Ma c'era tutto quello che ti serviva! 
Giacomo: C'era tutto, ho finito il vino e son venuto via... 
Giovanni: Ma se ti ho lasciato tre bottiglioni! 
Giacomo: Tre bottiglioni in una giornata van via, eh! Eh, la noia è dura da combattere... Federico! 
Giovanni: Giovanni! [Ad Aldo, che si è scandalizzato della presenza di Peppino] Figa... schiuma come un lupo! Questo qua è il nonno che mi han dato in affido. 
Aldo: Nonno in affido? 
Giovanni: Eh sì, ho firmato a un banchetto, pensavo per le primarie, invece era per avere il nonno in affido. 
Aldo: Ma dà fastidio? Ci si può fidare o...? 
Giovanni: No... no... è bravo... mangia, beve come un lupo, scoreggia come una locomotiva... e... e poi cosa c'ha, c'ha una punta d'Alzheimer e un'altra malattia che non mi ricordo, boh... [Vede Peppino che si sporge dal palazzo] Nonno, attenzione, è pericoloso! Non c'é il parapetto! Son trenta piani! 
Giacomo: È bello profondo, eh! Porca troia, saran cento foot!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 144,
                column: "Content",
                value: @"Aldo: Peppino! Come la va la famiglia? [Peppino comincia a piangere] 
Giovanni: Ma se è in affido non ce l'ha la famiglia, no?! Ma sei deficiente?!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 145,
                column: "Content",
                value: @"Aldo: Peppino! Chissà quante ne hai da raccontare ai tuoi nipoti... [Peppino piange] 
Giovanni: Ma allora sei deficiente! Se non ha la famiglia, non ha i nipoti! Cambia argomento! Un altro argomento, dai! 
Aldo: [Abbraccia Peppino] Peppino! Non fare così ti prego! Scusami! Se vuoi... che squadra tieni?? [Peppino piange disperatamente] 
Giovanni: Ma tiene all'Inter! 
Aldo: E che ne so io!!!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 146,
                column: "Content",
                value: @"Giacomo: Eran quattro Fenici di merda che se li incontro... BAM! 
Aldo: [Ironico] Fenicità! No... dico... ""Fenicità"" cioè... è Napo-Napo-Napo-Napoletano... 
Giacomo: Ma le spieghi anche le cagate che dici?!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 147,
                column: "Content",
                value: @"Aldo: Ascoltami... quella è la capanna dello zio Tom. e qui, tra il Tigri e l'Eufrate devi stare attento che non entri nessuno. Se per caso entra qualcuno, chiedi la parola d'ordine... 
Giacomo: Password. 
Aldo: No, la decidiamo insieme, non è che devi decidere da solo. Per esempio ""La parola d'ordine..."" 
Giacomo: Password! 
Aldo: La parola d'ordine è... 
Giacomo: Password! 
Aldo: Ahh, ""vaffanculo""! La decido io, e basta, e che è, la deve decidere lui ? !");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 148,
                column: "Content",
                value: @"Aldo: [Preoccupato perché gli sembra che Peppino gli abbia infilato il tappino del bastone nel sedere toccandolo] Peppino... c'era il tappino prima nel bastone? 
Giacomo: Certamente! 
Aldo: Ho paura a chiederlo... e che fine ha fatto? 
Giacomo: Inside your body! 
Aldo: [Guarda Giovanni] Non so l'inglese, ma credo di aver capito... Se mi muovo con cautela non lo sento, ma se mi muovo shakerando lo sento...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 150,
                column: "Content",
                value: @"Aldo: [Giovanni si prepara a saltare giù, e Aldo fa il conto alla rovescia] Allora.. UNO... sgombra la mente... DUE... sgombra la mente... TRE... [Si ferma all'improvviso] EH OH! FERMATI!!! 
Giovanni: Cosa c'è?! 
Aldo: Santo Iddio! [Lega la corda a cui era fissato Giovanni] 
Giovanni: [Guarda Giacomo, scandalizzato] Ma non aveva messo la corda!? 
Giacomo: È un Ugonotto! Non fidarti! 
Giovanni: Ma che Ugonotto! [Ad Aldo] Ma non avevi messo la corda!? 
Aldo: E vabbé... non è successo niente! Perché mi guardi con quegli occhi? 
Giovanni: Eh... no, un miracolo è successo! 
Aldo: Appunto, avevamo bisogno di un miracolo, l'abbiamo avuto! 
Giovanni: Eh se ne abbiam bisogno due son spacciato! 
Aldo: Uno ce ne serviva!! 
Giovanni: Speriamo... ma poi l'hai mai fatto? 
Aldo: L'ho visto fare migliaia di volte! 
Giovanni: [A Giacomo, terrorizzato] L'ha visto fare, non l'ha mai fatto!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 151,
                column: "Content",
                value: @"Aldo: [Peppino non torna su e Aldo tira la corda a sé] È molle! 
Giovanni: È molle? 
Aldo: È leggero... 
Giovanni: Adesso quando arriva il messo cosa gli do io, il bambolotto!? 
Aldo: [Urla dopo aver tirato su la corda e aver visto legata ad essa solo una gamba di Peppino] AHH!! AHH!! AHH!! Ma che cosa abbiamo combinato?? 
Giovanni: [Guarda la gamba di Peppino e si ricorda] Ecco qual era l'altra malattia che non mi ricordavo! Osteoporosi!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 152,
                column: "Content",
                value: @"Moglie di Giovanni: Che fai, non saliamo?
Giovanni: Prima controllo le gomme!
Moglie di Giovanni: A quest'ora?!
Giovanni: Perché, c'è un'ora?
Moglie di Giovanni: Scusa, ma non le avevi controllate ieri quando sei andato a lavare la macchina dentro e fuori e hai fatto benzina?
Giovanni: Sì, ma non mi fido! Metti che stanotte l'umidità me le ha fatte scendere di 2 atmosfere!
Moglie di Giovanni: Mamma mia...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 153,
                column: "Content",
                value: @"Suocera di Aldo: Le gomme anteriori sono sgonfie, eh!
Aldo: Embé?
Suocera di Aldo: Embé, non è sicuro!
Aldo: Le ho sgonfiate apposta! Metti che passiamo sotto un cavalcavia troppo basso, che faccio, scendo e sgonfio le gomme?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 154,
                column: "Content",
                value: @"Suocera di Aldo: Solo tu potevi sbagliare macchina, guarda!
Aldo: E intanto nessuno se n'è accorto!
Figlio di Aldo: Papà, veramente io...
Aldo: Sta' zitto tu! Pensa piuttosto a giocare con le figurine dei calciatori!
Figlio di Aldo: Ma papà, a me piace la filosofia, hai presente Kant?
Aldo: Sì, come no, l'ho incontrato proprio ieri! Gli piace la filosofia... ma sei sicura che è figlio mio?
Suocera di Aldo: Be', veramente tu sei sempre in giro, vero?
Aldo: Ma che dici?!? Rita, hai qualche cosa da confessarmi?!
Rita: Ma che dici amore, è solo che ha gusti diversi dai suoi compagnetti!
Aldo: Gusti diversi?! In che senso?!
Figlio di Aldo: Io sono...
Aldo: Non lo dire, non lo voglio sapere!
Figlio di Aldo: Sono... 
Aldo: Non lo... [Tappandosi le orecchie] La-la-la-la-la-la-la-la... 
Figlio di Aldo: Sono agnostico, papà!
Aldo: [Tirando un sospiro di sollievo] Agnostico... E io che mi credevo che eri... Ma che vuol dire agnostico?
Suocera di Aldo: Omosessuale, no? Vieni da nonna, dai!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 155,
                column: "Content",
                value: @"Giovanni: E dai, dì qualcosa anche tu, cosa ti piace? [del posto dove si stanno recando in vacanza] 
Moglie di Giovanni: Cosa mi piace? Il viaggio di ritorno. 
[Giovanni improvvisamente frena] Giovanni: Eh no, eh! Non si parte con questo spirito! [Tutti quanti esultano] Questo è lo spirito giusto, bravi! [Riparte con la macchina]");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 156,
                column: "Content",
                value: @"[Dopo aver assistito a una pallonata dei bambini sulla sua macchina] Eh no, eh! Eh no, eh no, eh no, eh! Guardate che ve lo buco quel pallone!
Aldo: Ma lasciali fare, son bambini!
Giovanni: No, sono i tuoi bambini! 
Aldo: Ora ci mettiamo a guardare se sono miei o sono tuoi, i bambini sono bambini. 
Giovanni: No, questi sono tuoi tuoi! 
Aldo [con aria spazientita]: Bambini, andate a giocare più lontano, va! 
Moglie di Aldo: Smettetela di litigare, eh, qui c'è il pane, le olive e il salame. 
Suocera di Aldo: Chi è che vuole una tazza di cioccolata?
Aldo: Ci sono 40 gradi all'ombra e tu ti metti a bere un Ciobar?
Suocera di Aldo: Bere caldo fa sentire freschi!
Aldo: Ma chi te le dice tutte 'ste minchiate?!
Giacomo [guardando il salame]: Ah però, trentasei euro al chilo! Colazione da Tiffany!
Aldo: Trentasei euro al chilo? Rita, ma sei matta?! Io mi spezzo la schiena in due e tu mi sperperi tutto il patrimonio? Ho un tenore di vita da Tronchetti Provera senza capitale e quella mi spende come Afef!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 157,
                column: "Content",
                value: @"Padre Bruno: Io ti assolvo nel nome del Padre, del Figlio e dello Spirito Santo, Amen. 
Signora: Grazie Padre. 
[Fuori campo] Mario: Vergogna. 
Signora: Come? 
Padre Bruno: Cosa c'è? 
Signora: Non so, mi è sembrato di sentire una voce, un rimprovero. 
Padre Bruno: Ecco, brava, continua ad ascoltare la voce del tuo cuore, figliola. 
Signora: Sì, Padre. [Va via] 
Padre Bruno: Mario... [Mario esce da dietro il confessionale] Quante volte te lo devo dire che non puoi ascoltare le confessioni? 
Mario: Quella donna ha messo le corna al marito e se la cava con tre Ave Maria?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 158,
                column: "Content",
                value: @"Mario [parlando con Padre Bruno dell'importanza della confessione]: Ma io ho tanto bisogno di Dio... 
Padre Bruno [aprendo la tendina del confessionale]: Tu hai tanta paura di andare all'Inferno! Da quant'è che non ti confessi? 
Mario: Be'... c'era ancora Pertini... abbiam vinto i mondiali... 2006? 
Padre Bruno: '82! [chiude la tendina del confessionale] 
Mario: Come passa il tempo...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 159,
                column: "Content",
                value: @"Mario: Già che è qua, Padre, ma la resurrezione riguarda solo l'anima o anche il corpo? 
Padre Bruno [stufo della solita domanda]: La resurrezione è dell'anima e del corpo. 
Mario: Ah, ma nel senso di carne e ossa...? 
Padre Bruno: Ahh, nel senso che l'uomo ritorna a Dio! 
Mario: Sì, ma col suo corpo o con un corpo diverso? 
Padre Bruno: Nel tuo caso sarebbe meglio che tu rinascessi con un corpo diverso!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 160,
                column: "Content",
                value: @"Beniamino [confessandosi]: Sono confuso, non ho dormito tutta la notte!
Padre Bruno: Tranquillo, figliolo, apri pure il tuo cuore, che qui siamo nella casa del Signore.
Mario: Sì, ma veniamo al dunque, padre!
Padre Bruno: Tu... levati di qua! Quante volte ti ho detto che non puoi ascoltare le confessioni?! [...]
Beniamino: Mi è caduta dal cielo!
Padre Bruno: Chi?
Beniamino: La valigia! [...]
Mario: Sì, ma cosa c'è dentro nella valigia?
Padre Bruno: Il Signore perdoni la nostra malsana curiosità... Cosa c'è nella valigia?
Beniamino: Soldi!
Padre Bruno: Soldi?! Quanti?
Beniamino: Tanti.
Padre Bruno: Tanti quanti?!
Beniamino: Troppi.
Padre Bruno: Troppi?!
Mario: Non sono mai troppi i soldi, Padre!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 161,
                column: "Content",
                value: @"Beniamino: Biscotti e vin santo? 
Mario: Ma ti sembra il momento? [prende e mangia un biscotto] Mmh, buoni! Sono artigianali? 
Beniamino: Sì: ""CroccaDog"". 
Mario [sputa disgustato il biscotto]: Ma son biscotti per cani! 
Beniamino: Ricchi di fibre, cereali, e frutta secca!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 162,
                column: "Content",
                value: @"Aldo: Ora provo il giro della morte! 
Giacomo: Ma no, non lo fare! 
Giovanni: Ci ha già provato il Conte di Montecristo, hai visto che cosa gli è successo? L'hanno rotolato dentro una tela e rinchiuso in uno sgabuzzino!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 163,
                column: "Content",
                value: @"Aldo: Je suis un cavalier! 
Giacomo e Giovanni: Cavaliere? 
Aldo: Oui? 
Giacomo e Giovanni: Prrrrrrrrrrr!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 164,
                column: "Content",
                value: @"Giovanni e Giacomo: Napoleon? 
Napoleone: Oui? 
Giovanni e Giacomo: Prrrrrrrrrrr!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 165,
                column: "Content",
                value: @"Giacomo: Com'è che si chiama [il figlio di Giovanni]?
Moglie di Giacomo: Saturnino.
Giacomo: Ma che nome è?
Moglie di Giacomo: È il nome del nonno.
Giacomo: Se il nonno si chiamava Nosferatu, chiamavano il bambino Nosferatu?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 166,
                column: "Content",
                value: @"Dott.ssa Gastani Frinzi: Hmm, no. Lo spermiogramma non ci dà delle belle notizie, hmm... La maggior parte degli spermatozoi è morta. I rimanenti possiedono una motilità scarsissima, direi. Desidera un caffè?
Giacomo: Sì grazie, se ci fosse un cafferino, magari...
Moglie di Giacomo: Amore, dai, lascia perdere, sei già abbastanza nervoso.
Giacomo: Ma non sono nervoso!
Moglie di Giacomo: E quindi la situazione quale sarebbe?
Dott.ssa Gastani Frinzi: Glielo spiego in altre parole: questi spermatozoi sono stanchi, sono deboli, non hanno proprio il vigore, non possono raggiungere l'obiettivo, non so come dire... sono impigriti, svogliati, sa, proprio senza nerbo... sono... poco motivati, poco motivati. Ma come mai, signor Poretti?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 167,
                column: "Content",
                value: @"Moglie di Giacomo: Ma non c'è proprio niente che possiamo fare? 
D.ssa Alexandra Gastani Frinzi: Si un paio di cose: o cambiare partner... ahahah, no, scherzavo, dai, scherzavo, non si intristisca, già questi sono depressi...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 168,
                column: "Content",
                value: @"Aldo: Mio figlio... si fa le canne...
Giovanni: Eh, col padre che si ritrova è un miracolo che non faccia lo stupratore...
Aldo: Forse commette anche quel reato...
Giovanni: Allora facciamo che da oggi non ci conosciamo.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 169,
                column: "Content",
                value: @"Dott.ssa Gastani Frinzi: Signor Poretti! Lei si è applicato? 
[Guardandosi con la moglie] Giacomo: ...Sì. 
Dott.ssa Gastani Frinzi: Eh, non sembra! Eh no, perché proprio questi spermatozoi non vogliono vincere, eh? Qui non c'è cattiveria, manca proprio lo sguardo della tigre in questi semini! 
[Guardandosi con la moglie] Giacomo: ...Semini?! 
Dott.ssa Gastani Frinzi: La temperatura basale l'avete presa? 
Moglie di Giacomo: Certo. 
Dott.ssa Gastani Frinzi: Sì, ma come ho detto io? 
Giacomo: Sì. 
Dott.ssa Gastani Frinzi: Sicuro? 
Giacomo: Sicuro. 
Dott.ssa Gastani Frinzi: ...Ve lo rispiego. 
Giacomo: Dottoressa, guardi che non siamo mica scemi. 
Moglie di Giacomo: Amore, non ti arrabbiare che fa male agli spermatozoi... no? Non c'è piuttosto un'altra possibilità? 
Dott.ssa Gastani Frinzi: Sì, secondo me a questo punto potete rivolgervi alla banca del seme. 
Giacomo: Sì, per un mutuo! 
Dott.ssa Gastani Finzi: Lo sa che io al suo posto non farei tanto lo spiritoso? 
Giacomo: Senta, Dottoressa Frinzi...
Dott.ssa Gastani Frinzi: Gastani Frinzi. 
Giacomo: Senti, Gastani Frinzi, lo sai che se ti trovo in giro in macchina io ti tiro sotto? 
Moglie di Giacomo: Amore, ma cosa dici? 
Giacomo: Tieni giù le mani porca di quella puttana! Gastani Frinzi dei miei coglioni! [Esce dalla stanza] Dove cazzo si esce in questo posto di merda?! 
Moglie di Giacomo: Scusi Dottoressa Frinzi. 
[Visibilmente perplessa] Dott.ssa Gastani Frinzi: ...Ga ..Gas... Gastani Frinzi. 
Giacomo: L'avete concepita una porta o no? 
Moglie di Giacomo: Volevo dire Gastani Frinzi, mi scusi. Facciamo con la segretaria, no? Amore! 
Giacomo: Ah, perché ti devo anche pagare? Ma vaffanculo va!");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 170,
                column: "Content",
                value: @"Giovanni: Hai visto che gol di sinistro? Proprio sotto la traversa...
Aldo: Lo avrebbe fatto anche mio nonno!
Giovanni: Ma se è morto!
Aldo: Appunto. Mi passi lo shampoo?
Giovanni: E che cazzo te ne fai?");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 171,
                column: "Content",
                value: @"Aldo [parlando di suo figlio]: Si è fatto bocciare. Che vergogna. 
Giacomo: Ma chi? 
Aldo: Il maggiore. 
Giacomo: Ah, ""lo scienziato""! 
Giovanni: Per forza, con tutte le canne che si fa. [Giacomo ride] 
Aldo: Ma ti rendi conto che è il primo dell'albero genealogico a farsi bocciare? 
Giovanni: Be', su questo ho molti dubbi. Credo che se cerchi bene tra i rami qualcuno c'è già. 
Aldo: Ma io lo mando a lavorare quel disgraziato. 
Giovanni: Ecco, in questo caso sarebbe proprio il primo dell'albero.");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 172,
                column: "Content",
                value: @"Irene: C'è qualche terrone qui? [Giovanni e Giacomo fissando Aldo]
Aldo: Effettivamente sono nato a Palermo... però come ben può vedere ho delle forti contaminazioni normanne... poi mio papà mi ha iscritto qui, a metà strada tra le due culture... 
Irene: Ma che cazzo stai dicendo?!
Aldo [in preda alla disperazione]: La prego, dottoressa... c'è stato uno sbaglio: siamo innocenti!
Irene: Sei tu, sei tu che hai avuto la brillante idea di farvi beccare proprio stasera, eh?! Ma che razza di banda siete??");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 173,
                column: "Content",
                value: @"Giacomo: T'ha cacciato a pedate nel culo? 
Aldo: Ho avuto un misunderstanding! 
Giovanni: Cosa?! 
Aldo: Un pacato confronto tra persone adulte...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 174,
                column: "Content",
                value: @"Gualtiero: Certo che come giocatore sei proprio una merda! 
Aldo: Ma se sei tu che mi hai suggerito il tris sicuro! Dicevi he Gazzaladra era più veloce di un Porsche e aveva l'argento vivo di un termosifone! Gualtiero...");

            migrationBuilder.UpdateData(
                table: "Dialogues",
                keyColumn: "Id",
                keyValue: 175,
                column: "Content",
                value: @"Giacomo: Ludmilla! Una colonscopia al paziente ventitré! 
Paziente: Ohhh, che super-io spigoloso! 
Giacomo: Vedrà che colonscopia spigolosa!");
        }
    }
}

# AldoGiovanniGiacomo.API
REST API we don't deserve but we need.

[![Build Status](https://travis-ci.com/giuseppebrb/AldoGiovanniGiacomo.API.svg?token=pCEEhkoJAsRoSpQFU8q4&branch=master)](https://travis-ci.com/giuseppebrb/AldoGiovanniGiacomo.API) [![Build Status](https://dev.azure.com/giuseppebrb/AldoGiovanniGiacomo.API/_apis/build/status/aldogiovannigiacomoapi%20-%20CI?branchName=master)](https://dev.azure.com/giuseppebrb/AldoGiovanniGiacomo.API/_build/latest?definitionId=3&branchName=master) ![Api Version](https://img.shields.io/badge/API%20Version-v1-blue)

###### Check the live version here (Swagger page): [https://aldogiovannigiacomoapi.azurewebsites.net/swagger](https://aldogiovannigiacomoapi.azurewebsites.net/swagger/index.html)
###### Endpoints list [here](#endpoints-list).

[Italian Version](#italian-version-) <img src="https://emojipedia-us.s3.dualstack.us-west-1.amazonaws.com/thumbs/120/google/146/flag-for-italy_1f1ee-1f1f9.png" width="30" height="25">

## English Version <img src="https://emojipedia-us.s3.dualstack.us-west-1.amazonaws.com/thumbs/120/google/146/flag-for-united-kingdom_1f1ec-1f1e7.png" width="30" height="25">

### News
I created a Slack Application (coded in Node.js) that uses these APIs. You can take a look at the repository here: [AldoGiovanniGiacomoSlackApp](https://github.com/giuseppebrb/AldoGiovanniGiacomoSlackApp).
<br />
<a href="https://slack.com/oauth/authorize?client_id=744917847047.745107739717&scope=commands"><img src="https://www.eletype.com/wp-content/uploads/Add-to-Slack-Button@2x.png" height="48"></a>

### What Is This?
This is a simple **REST API** whose purpose is to provide quotes and infos about *Aldo, Giovanni e Giacomo* (a popular comic trio in Italy).

### How It's Made? ©
This API is an **ASP.NET CORE 3.1** Web Application solution.
Packages/Technologies involved are:
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [NSwag](https://github.com/RicoSuter/NSwag) (to generate Swagger UI and OpenAPI docs)

CI/CD (Continuous Integration/Continuous Delivery) are provided by Travis-CI; you can find build history [here](https://travis-ci.com/giuseppebrb/AldoGiovanniGiacomo.API/builds)
The live version is hosted on Microsoft Azure @ [https://aldogiovannigiacomoapi.azurewebsites.net/swagger](https://aldogiovannigiacomoapi.azurewebsites.net/swagger/index.html).

If you wish, you can also download a collection of Postman calls [here](https://github.com/giuseppebrb/AldoGiovanniGiacomo.API/blob/master/AldoGiovanniGiacomoAPI.postman_collection.json)

### Setup Locally
Setting up the project locally is pretty simple: just clone the repository and in the [Package Manager Console](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-powershell#opening-the-console-and-console-controls) run `Update-Database` in order to create and seed the local database.

In case something goes wrong during this task, just update the connection string inside **appsettings.Development.json** with your own local connection string.

### What's Next?
This project has been created just for fun but I'd like to give it a serious facade.
Here's what I planned next:
1. Upload a testing project for this API; :white_check_mark:
2. Give suppurt not only for single quotes but for dialogues too. :white_check_mark:
3. A page to allow user to submit their favourite Aldo, Giovanni e Giacomo quotes (after approvation).

Maybe create bots/extensions for client like Slack, Skype, etc...

##### Any Fork/Pull request/Suggestion/Comment/Help are welcome!! :smiley:

---------------------------------------

## Italian Version <img src="https://emojipedia-us.s3.dualstack.us-west-1.amazonaws.com/thumbs/120/google/146/flag-for-italy_1f1ee-1f1f9.png" width="30" height="25">

### News
Ho creato una applicazione Node.js per Slack che usa queste API. Potete dare un'occhiata al repository qui: [AldoGiovanniGiacomoSlackApp](https://github.com/giuseppebrb/AldoGiovanniGiacomoSlackApp).
<br />
<a href="https://slack.com/oauth/authorize?client_id=744917847047.745107739717&scope=commands"><img src="https://www.eletype.com/wp-content/uploads/Add-to-Slack-Button@2x.png" height="48"></a>

### Che cos'è?
Semplici **REST API** con lo scopo di fornire citazioni ed informazioni su Aldo, Giovanni e Giacomo.

### Com'è fatto?
Queste API sono create in una soluzione **ASP.NET CORE 3.1** Web Application.
Altre tecnologie/pacchetti coinvolti durante la creazione sono:
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [NSwag](https://github.com/RicoSuter/NSwag) (per generare la documentazione OpenAPI e l'interfaccia grafica di Swagger)

CI/CD (Continuous Integration/Continuous Delivery) sono forniti da Travis-CI; potete trovare la *build history* [qui](https://travis-ci.com/giuseppebrb/AldoGiovanniGiacomo.API/builds)
La *live version* è hostata su Microsoft Azure @ [https://aldogiovannigiacomoapi.azurewebsites.net/swagger](https://aldogiovannigiacomoapi.azurewebsites.net/swagger/index.html).

Se volete, potete scaricare anche una collezione di chiamate in Postman [qui](https://github.com/giuseppebrb/AldoGiovanniGiacomo.API/blob/master/AldoGiovanniGiacomoAPI.postman_collection.json)

### Setup Locale
Settare il progetto in locale per procedere allo sviluppo è piuttosto semplice: basta clonare questo repository e nella [Package Manager Console](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-powershell#opening-the-console-and-console-controls) lanciare il comando `Update-Database` per creare e popolare il database in locale.

Qualora qualcosa dovesse andare storto durante questo processo, cambiare la stringa di connessione presente nel file **appsettings.Development.json** con la propria stringa di connessione locale.

### In futuro?
Questo progetto è nato per divertimento (chi non vorrebbe un generatore costante di citazioni di Aldo, Giovanni e Giacomo ?!) tuttavia vorrei che venisse sviluppato in maniera *"seria"*.
A seguire quello che ho pianificato per il futuro:
1. Caricamento di un progetto di test per queste API; :white_check_mark:
2. Supportare non solo citazioni di frasi singole ma anche di dialoghi. :white_check_mark:
3. Creazione di una pagina per permettere agli utenti l'inserimento (previa approvazione) di altre citazioni di Aldo, Giovanni e Giacomo.

Forse creare chatbot/estensioni per client come Slack, Skype, ecc...

##### Qualsiasi Fork/Pull Request/Suggerimento/Commento/Aiuto è più che benvenuto! :smiley:
##### Se volete aggiungere citazioni al seed iniziale del database, potete farlo dal DBContext nella folder *Contexts*

### Endpoints list
|                                       Endpoint examples                                      |                               Description                               |
|----------------------------------------------------------------------------------------------|-------------------------------------------------------------------------|
| https://aldogiovannigiacomoapi.azurewebsites.net/api/actors                                  | Retrieve anagraphic infos about the actors Aldo, Giovanni e Giacomo     |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/actors/{id}                             | Retrieve anagraphic details about an actor     
|
| https://aldogiovannigiacomoapi.azurewebsites.net/api/actors/add                              | Add a new actor inside the list of actors
|
| https://aldogiovannigiacomoapi.azurewebsites.net/api/actors/{id}/quotes                      | Gets every quote, taken from every movie, said by the specified actor   |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/actors/{id}/quotes/random               | Get a random quote, from a random movie, said by the specified actor    |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/actors/{actorId}/quotes/{quoteId}       | Get a specific quote said by the specified actor                        |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/dialogues                               | Gets every dialogue, from every movie, said by Aldo, Giovanni e Giacomo |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/dialogues/add                           | Add a new dialogue to the list of dialogues
|
| https://aldogiovannigiacomoapi.azurewebsites.net/api/dialogues/{id}                          | Gets a specific dialogue                                                |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/dialogues/random                        | Gets a random dialogue from a random movie                              |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/movies                                  | Gets the movie list of Aldo, Giovanni e Giacomo with details            |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/movies/add                              | Add a new movie to the list of movies
|
| https://aldogiovannigiacomoapi.azurewebsites.net/api/movies/{id}                             | Gets details of the specified movie                                     |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/movies/{id}/quotes                      | Gets a list of quotes taken from the specified movie                    |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/movies/{id}/quotes/random               | Get a random quote taken from the specified movie                       |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/movies/{movieId}/quotes/{quoteId}       | Get a specific quote from the specified movie                           |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/movies/{id}/dialogues                   | Gets a list of dialogues taken from the specified movie                 |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/movies/{id}/dialogues/random            | Get a random dialogue taken from the specified movie                    |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/movies/{movieId}/dialogues/{dialogueId} | Get a specific quote from the specified movie                           |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/quotes                                  | Gets every quote, from every movie, said by Aldo, Giovanni e Giacomo
| 
| https://aldogiovannigiacomoapi.azurewebsites.net/api/quotes/add                              | Add a new quote inside the list of quotes  
|
| https://aldogiovannigiacomoapi.azurewebsites.net/api/quotes/{id}                             | Gets specified quote                                                    |
| https://aldogiovannigiacomoapi.azurewebsites.net/api/quotes/random                           | Gets a random quote from a random movie                                 |

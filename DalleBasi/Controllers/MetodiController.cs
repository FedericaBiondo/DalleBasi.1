using DalleBasi.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;


namespace DalleBasi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MetodiController : Controller // API semplice che rimanda un messaggio "Hello World" - solo con metodo GET

    {
        List<ClasseModel> listaOggetti = new List<ClasseModel>(); // come si aggiunge un og in lista in .net (stesso tipo)
        ClasseModel oggetto = new ClasseModel();

        [HttpGet] //Get rimanda dati da una risposta
        public async Task<ActionResult<string>> GetString()
        {
            return "Hello world";
        }

        [HttpPost] // con metodo Post che elabora dati inviati dal cliente e restituisce risposta
        public async Task<ActionResult> PostData([FromBody] ClasseModel classemodel) //Postdata(=metodo) riceve oggetto ClasseModel
                                                                                     // è un metodo che accetta parametri in input un classemodel e stampa i valori che ho usato per popolarlo. lo agg in lsita e lo ritorna 
        {
            Console.WriteLine($"Federica={classemodel.Nome} Biondo={classemodel.Cognome} 1234=({classemodel.CF})"); // è una stringa interpolata. 
            //listaOggetti.Add(classemodel); //quando si chiama il metodo PostData, l'og classe model viene aggiunto alla listaOggetti

                                                    // Per lunedi 04 - 03: inserire 5 elementi in lista con ciclo for e vedere come funziona
            for (int i = 1; i <= 5; i++) // con questo ciclo avremo 5 nuovi elementi: fino a Nome5, fino a Cognome5 e Cf fino a 6.
            {                               // For= l'inizializzazione int i=1 crea una varibile e la fa iniziare con 1. La condizione i <=5 viene eseguita ogni volta. La condizione continua fino a quando non restituisce false.
                //ClasseModel nuovoOggetto = new ClasseModel
                //{
                //    Nome = $"Nome{i}", 
                //    Cognome = $"Cognome{i}",
                //    CF = 24 + i 
                //};
                listaOggetti.Add(classemodel);  
            }
            return Ok(listaOggetti);  // metodo Ok identifica anche i cod con cui mi può ritornare l'og.

                                        // Ogni volta mi devo domandare: "Cosa devo fare per arrivare a return che è la fine del metodo?".
        }
                                                            
                                                            
        public class ClasseModel     

        {
            public string? Nome { get; set; }
            public string? Cognome { get; set; }
            public int CF { get; set; }
        }

      
    } 
}


   


    


    









        


            //[HttpPost(template: "KnowledgeBase")]

            //public async Task<string> TestKnowledgeBase([FromBody] QuestionInput question) { }
        
    







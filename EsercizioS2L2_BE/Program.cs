using EsercizioS2L2_BE.Models;

namespace EsercizioS2L2_BE
{
    class Program
    {
        static void Main(string[] args)
        {
            CV curriculum = new CV
            {
                InformazioniPersonali = new InformazioniPersonali
                {
                    Nome = "Francesca",
                    Cognome = "Palmeri",
                    Telefono = "366994653",
                    Email = "francesca.p@tiscali.it"
                },
                StudiEffettuati = new List<Studi>
                    {
                        new Studi
                        {
                            Qualifica = "Master di illustrazione digitale",
                            Istituto = "Genius Academy",
                            Tipo = "Altra formazione",
                            Dal = new DateTime(2020, 9, 1),
                            Al = new DateTime(2021, 2, 28)
                        },
                        new Studi
                        {
                            Qualifica = "Laurea in Lingue Orientali",
                            Istituto = "Università degli Studi di Roma La Sapienza",
                            Tipo = "Triennale",
                            Dal = new DateTime(2014, 10, 1),
                            Al = new DateTime(2018, 3, 28)
                        }
                    },
                Impieghi = new List<Impieghi>
                    {
                        new Impieghi
                        {
                            Esperienza = new List<Esperienza>
                            {
                                new Esperienza
                                {
                                    Azienda = "Bucap",
                                    JobTitle = "Archivista",
                                    Dal = new DateTime(2021, 4, 1),
                                    Al = new DateTime(2024, 9, 30),
                                    Descrizione = "Impiegata d'archivio",
                                    Compiti = "Acquisizione, smistamento e gestione documentale"
                                },
                                new Esperienza
                                {
                                    Azienda = "PincoPallo",
                                    JobTitle = "Cameriera",
                                    Dal = new DateTime(2018, 4, 1),
                                    Al = new DateTime(2018, 9, 30),
                                    Descrizione = "Cameriera per ristorante di alta qualità",
                                    Compiti = "Servizio clienti e gestione tavoli"
                                }
                            }
                        }
                    }
            };

            StampaCurriculum(curriculum);
        }

        static void StampaCurriculum(CV cv)
        {
            Console.WriteLine($"CV di {cv.InformazioniPersonali.Cognome} {cv.InformazioniPersonali.Nome}");
            Console.WriteLine("++++ INIZIO Informazioni Personali ++++");
            Console.WriteLine($"Nome: {cv.InformazioniPersonali.Nome}");
            Console.WriteLine($"Cognome: {cv.InformazioniPersonali.Cognome}");
            Console.WriteLine($"Telefono: {cv.InformazioniPersonali.Telefono}");
            Console.WriteLine($"Email: {cv.InformazioniPersonali.Email}");
            Console.WriteLine("++++ FINE Informazioni Personali ++++");
            Console.WriteLine("                    ");
            Console.WriteLine("++++ INIZIO Studi e Formazione: ++++");
            foreach (var studio in cv.StudiEffettuati)
            {
                Console.WriteLine($"Istituto: {studio.Istituto}");
                Console.WriteLine($"Qualifica: {studio.Qualifica}");
                Console.WriteLine($"Tipo: {studio.Tipo}");
                Console.WriteLine($"Dal {studio.Dal} al {studio.Al}");
                Console.WriteLine("                    ");
            }

            Console.WriteLine("++++ FINE Studi e Formazione ++++");
            Console.WriteLine("                    ");
            Console.WriteLine("++++ INIZIO Esperienze professionali: ++++");
            foreach (var impiego in cv.Impieghi)
            {
                foreach (var esperienza in impiego.Esperienza)
                {
                    Console.WriteLine($"Presso: {esperienza.Azienda}");
                    Console.WriteLine($"Tipo di Lavoro: {esperienza.JobTitle}");
                    Console.WriteLine($"Compito: {esperienza.Compiti}");
                    Console.WriteLine($"Dal {esperienza.Dal} al {esperienza.Al}");
                    Console.WriteLine("                    ");

                }
            }
            Console.WriteLine("++++ FINE Esperienze professionali ++++");
        }
    }
}

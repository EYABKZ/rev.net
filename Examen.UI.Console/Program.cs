// See https://aka.ms/new-console-template for more information
//using Examen.ApplicationCore.Domain;
//using Examen.ApplicationCore.Services;
//using Examen.Infrastructure;
//using System.ComponentModel.DataAnnotations.Schema;

//Console.WriteLine("Hello, World!");


//GFContext ctx=new GFContext();
//Chanson chanson=new Chanson();  
//UnitOfWork uow = new UnitOfWork(ctx);
//ChansonServiceImpl csi=new ChansonServiceImpl(uow);

//csi.Add(chanson);
//csi.Commit();







//Artiste artiste1 = new Artiste
//{ ArtisteId = 1, Nom = "Dupont", Prenom = "Jean",DateNaissance = new DateTime(2024, 11, 08, 10, 10, 00), Contact = "tttt",Nationalite = "Française"};

//Artiste artiste2 = new Artiste
//{ ArtisteId = 2, Nom = "Dupont", Prenom = "Jean", DateNaissance = new DateTime(2024, 11, 08, 10, 10, 00), Contact = "tttt", Nationalite = "Française" };
//UnitOfWork uow2 = new UnitOfWork(ctx);
//ArtisteServiceImpl csi2 = new ArtisteServiceImpl(uow2);
//csi2.Add(artiste1);
//csi2.Add(artiste2);
//csi2.Commit();  

//Plane plane1 = new Plane { Capacity = 100, ManufactureDate=new DateTime(2024,11,08),PlaneType=PlaneType.Airbus };

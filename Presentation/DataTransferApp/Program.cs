// See https://aka.ms/new-console-template for more information
using System;
using Business.Context;
using Domain.Entities;
using Domain.ViewModels;
using Newtonsoft.Json;

//string localdata = File.ReadAllText("Sdata.json");
//var jsondata = JsonConvert.DeserializeObject<List<Spot>>(localdata);

string Idata = File.ReadAllText("akisveri.json");
var Ijsondata = JsonConvert.DeserializeObject<List<Flow>>(Idata);

foreach (var data in Ijsondata)
{
    var context = new SpotDBContext();
    context.Flow.Add(data);
    context.SaveChanges(); //commitlemek için
}


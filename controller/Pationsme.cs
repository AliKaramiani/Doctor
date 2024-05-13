
using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
[Route("[Action]")]
[ApiController]

public class Pationsme : ControllerBase
{
    Context db = new Context();
    [HttpPost]
    public string insert(Pations x)
    {
        db.Tbl_Pations.Add(x);
        db.SaveChanges();
        return "Done";


    }
    [HttpGet]
    public List<Pations> Getall()

    {

        return db.Tbl_Pations.ToList();


    }
    [HttpDelete]
    public string Delete(int Id)
    {

        var x = db.Tbl_Pations.Find(Id);
        db.Tbl_Pations.Remove(x);
        db.SaveChanges();
        return "1";

    }
    [HttpPut]
    public string Update(Pations x)
    {
        var result = db.Tbl_Pations.Find(x.Id);
        result.Name = x.Name;
        result.Family = x.Family;
        result.Nationalcode = x.Nationalcode;
        db.Tbl_Pations.Update(result);
        db.SaveChanges();
        return "Done";



    }

}
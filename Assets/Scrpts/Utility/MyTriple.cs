using System;

public class MyTriple{
    public MyTriple(int ID,string q,bool response){
        this.id=ID;
        this.q=q;
        this.r=response;
    }

    public int id { get; set; }
    public string q { get; set; }
    public bool r { get; set; }
}
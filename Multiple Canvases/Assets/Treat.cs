public class Treatment
{
    public int ID;
    public string Name;
    public string treatmentLocation;
    public string iconLocation;
    public float score;
    public Treatment(int num,string treatname,string tL,string iL,float im)
    {
        this.ID = num;
        this.Name = treatname;
        this.treatmentLocation = tL;
        this.iconLocation = iL;
        this.score = im;

    }
}
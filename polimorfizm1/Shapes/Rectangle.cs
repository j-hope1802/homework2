public class Rectangle :Shape{
    protected double width=1.0;
    protected double lenth=1.0;
    public Rectangle(){

    } 
    public Rectangle (double width,double lenth)
    {

    }
    public Rectangle (string color,bool filled  ) :base(color,filled)
    {

    }
    public double GetWidth(){
return width;
    }
    public void SetWidth(double width){
this.width=width;
    }
      public double GetLenth(){
return lenths;
    }
    public void SetLenth(double lenth){
this.lenth=lenth;
    }
    public double GetArea(){
        
    }
    public double GetPerimetr(){

    }
    public string toString(){
 return "Square , Rectangle" + color + "," + filled + ", "+  width + ", " + length;
    }
}
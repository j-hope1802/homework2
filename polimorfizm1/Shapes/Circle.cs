public class Circle :Shape{
    protected double radius=1.0;
  
    public Circle(){

    } 
    public Circle (double radius)
    {

    }
    public Circle (string color,bool filled  ) :base(color,filled)
    {

    }
    public double GetRadius(){
return radius;
    }
    public void SetWidth(double width){
this.radius=radius;
    }

    public double GetArea(){
        return radius* radius*Math.PI;
    }
    public double GetPerimetr(){
return 2*Math.PI*radius;
    }
    public string toString(){
        
    }
}
using TPN1_GonzalezSmithTomas.Models;

namespace TPN1_GonzalezSmithTomas.Services;

public static class CarService{
    static List<Car> Cars { get; set;}

    static CarService(){
        Cars = new List<Car>
        {
            new Car { Brand = "Volkswagen", Code="VWP2020", Name="Polo", Year=2020, Category="Hatchback"},
            new Car { Brand = "Ford", Code="FOE2007", Name="Ecosport", Year=2007, Category="SUV"},
            new Car { Brand = "Chevrolet", Code="CHC2022", Name="Cruze", Year=2022, Category="Sedan"},
            new Car { Brand = "Chevrolet", Code="CHS2012", Name="Spin", Year=2012, Category="Van"}
        };
    }

    public static List<Car> GetAll() => Cars;

    public static void Add(Car obj){
       if(obj == null){
         return;
       }

       Cars.Add(obj);
    }

    public static void Delete(string code){
        var carToDelete = Get(code);

        if (carToDelete != null){
            Cars.Remove(carToDelete);
        }
    }
    public static Car? Get(string code) => Cars.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());
}
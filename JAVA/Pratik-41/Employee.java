public class Employee {
    String name;
    Double salary;
    int workHours;
    int hireYear;

    public Employee(String name, Double salary, int workHours, int hireYear) {
        this.name = name;
        this.salary = salary;
        this.workHours = workHours;
        this.hireYear = hireYear;
    }

    public double tax(){
        if(salary > 1000){
            return salary * 0.03;
        }
        return 0;
    }

    public double bonus(){
        if(workHours > 40){
            return (workHours - 40) * 30;
        }
        return 0;
    }

    public double raiseSalary(){
        int year = 2021 - hireYear;
        if(year > 19){
            return salary * 0.15;
        }
        if(year > 9){
            return salary * 0.1;
        }
        return salary * 0.05;
    }

    @Override
    public String toString() {
        return  "Adı: " + name +
                "\nMaaşı: " + salary +
                "\nÇalışma Saati: " + workHours +
                "\nBaşlangıç Yılı: " + hireYear +
                "\nVergi: " + tax() +
                "\nBonus: " + bonus() +
                "\nMaaş Artışı: " + raiseSalary() +
                "\nVergi ve Bonuslar ile birlikte maaş: " + (salary - tax() + bonus()) +
                "\nToplam Maaş: " + (salary - tax() + bonus() + raiseSalary());
    }
}

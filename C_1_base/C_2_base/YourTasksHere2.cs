namespace C_2_base
{
    // Необходимо реализовать объектную модель геометрических фигур (прямоугольник, тругольник, круг).
    // Ко всем фигурам должно быть возможно осуществить доступ по одному имени 
    // Через это имя должно быть возможно получить доступ к площади и периметру фигур
    // Все числа пусть имееют тип double

    abstract class Figure
    {
        protected double area;
        protected double perimeter;

        public double Area
        {
            get { return area; }
        }

        public double Perimeter
        {
            get { return perimeter; }
        }

        protected virtual void calculate()
        {
        }
    }

    class Rectangle : Figure
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.calculate();
        }

        protected override void calculate()
        {
            base.area = sideA * sideB;
            base.perimeter = (sideA + sideB) * 2;
        }
    }

    class Triangle : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.calculate();
        }

        protected override void calculate()
        {
            base.perimeter = sideA + sideB + sideC;
            double halfP = base.perimeter / 2;
            base.area = System.Math.Sqrt(halfP * (halfP - sideA) * (halfP - sideB) * (halfP - sideC));
        }
    }

    class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
            this.calculate();
        }

        protected override void calculate()
        {
            base.perimeter = System.Math.PI * 2 * radius;
            base.area = System.Math.PI * radius * radius;
        }
    }
}

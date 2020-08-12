using System;
using ExemploSemInterface.Entities;

namespace ExemploSemInterface.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _TaxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            // Duração da locação
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            // Regra pagamento imposto
            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); // Ceiling = arredonda pra cima
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            //Calcular o serviço de imposto
            double tax = _TaxService.Tax(basicPayment);

            // Instanciar carRental
            carRental.Invoice = new Invoice(basicPayment, tax);
                                   
        }

    }
}

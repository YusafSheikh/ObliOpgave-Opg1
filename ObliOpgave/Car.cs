namespace ObliOpgave
{
    public class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }

        public int Price { get; set; }

        public string? LicensePlate { get; set; }

        public void ValidatePrice()
        {
            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException("Price must not be below 0: " + Price);
            }

        }

        public void ValidateId()
        {
            if (Id < 1)
            {
                throw new ArgumentOutOfRangeException("Id must be over 1" + Id);
            }
        }

        public void ValidateModel() 
        {
            if (Model == null)
            {
                throw new ArgumentNullException("Model is null");
            }

            if (Model?.Length < 4)
            {
                throw new ArgumentOutOfRangeException("Model must be at least 4 characthers");
            }
        }

        public void ValidateLicensePlate()
        {
            if (LicensePlate?.Length == null)
            {
                throw new ArgumentOutOfRangeException("License plate must be at least 2 characthers");
            }
            if (LicensePlate?.Length < 2 || LicensePlate?.Length > 7) 
            {
                throw new ArgumentOutOfRangeException("License plate must be max 7 characthers");
            }
        }
        public void Validate() 
        { 
            ValidatePrice();
            ValidateId();
            ValidateModel();
            ValidateLicensePlate();
        }  

      
    }
}
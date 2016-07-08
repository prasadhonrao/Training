public class CargoFlight extends Flight {
    // @Override declaration is options. This is just to explicitly indicate 
	// that this method overrides the base method
    @Override
    public int GetSeats(){
        return 12;
    }
}

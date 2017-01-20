package hardware;

public class Machine implements IMachine {

	private boolean isOn;

	@Override
	public void turnOn() {
		this.setOn(true);
		System.out.println("Machine is on");
	}

	@Override
	public void turnOff() {
		this.setOn(false);
		System.out.println("Machine is off");
	}

	public boolean isOn() {
		return isOn;
	}

	public void setOn(boolean isOn) {
		this.isOn = isOn;
	}

}

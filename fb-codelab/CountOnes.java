
public class CountOnes {
	
	public static void main(String[] args) {
		long number = 11L;
		String numberString = Long.toBinaryString(number);
		numberString = numberString.replaceAll("0","");
		System.out.println(numberString.length());
	}
	
}
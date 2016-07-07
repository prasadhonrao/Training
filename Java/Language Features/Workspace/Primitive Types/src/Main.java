public class Main {

    public static void main(String[] args) {
        // 1. INTEGER TYPES - byte (8), short (16), int (32), long (64)

        byte byteValue = 127;
        System.out.println(byteValue);

        short shortValue = 32767;
        System.out.println(shortValue);

        int intValue = 1000;
        System.out.println(intValue);

        long longValue = 22222235654677L;
        System.out.println(longValue);

        // 2. FLOATING POINT TYPE - float (32), double (64)
        float pi = 1.345f;
        System.out.println(pi);

        double newPi = 1.34566778d;
        System.out.println(newPi);

        // 3. CHARACTER - char
        char charValue = 'c';
        System.out.println(charValue);
        
        char accentedU = '\u00DA'; 
        System.out.println(accentedU);

        // 4. BOOLEAN
        boolean iLoveJava = true;
        System.out.println(iLoveJava);
    }
}
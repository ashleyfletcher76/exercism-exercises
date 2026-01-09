class Leap {

    boolean isLeapYear(int year) {
        return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);
    }
 
    // boolean isLeapYear(int year) {
    //     if (year % 4 != 0)
    //         return false;
    //     if (year % 100 == 0 && year % 400 == 0)
    //         return true;
    //     if (year % 100 == 0)
    //         return false;
    //     return true;
    // }

    // boolean isLeapYear(int year) {
    //     if (year % 4 == 0) {
    //         if (year % 100 == 0 && year % 400 == 0) {
    //             return true;
    //         } else if (year % 100 == 0) {
    //             return false;
    //         }
    //         return true;
    //     }
    //     return false;
    // }

}

// if div by 4 == true, div by 100 == false unless div by 100 && div by 400 then == true

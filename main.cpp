#include <iostream>

int main()
{   
    int price = 0, totalPrice = 0, discount;
    
    std::cout << "Total: ";
    
    std::cin >> totalPrice;
    
    if (totalPrice > 500)
    { 
         discount = (totalPrice * 8) / 100;
         price = totalPrice - discount;
         
         std::cout << price;
    } 
    else 
    {
         price = totalPrice;
         std::cout << price;     
    }
    
    return 0;   
}

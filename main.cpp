#include <iostream>

int main()
{   
    int price = 0, totalPrice = 0, discount;
    
    std::cout << "Siparisinizin toplam tutarini girin: ";
    
    std::cin >> totalPrice;
    
    if (totalPrice > 500)
    { 
         discount = (totalPrice * 8) / 100;
         price = totalPrice - discount;
         
         std::cout << "Indirim orani: %8" << std::endl;
         std::cout << "Toplam fiyat: " << price;
    } 
    else 
    {
         price = totalPrice;
         std::cout << "Toplam fiyat: " << price;     
    }
    
    return 0;   
}

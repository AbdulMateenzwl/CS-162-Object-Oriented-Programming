from math import radians
from SellerBL_f import Seller
from SellerDL_f import SellerDL
from ProductBL_f import Product
class SellerUI:
    @staticmethod
    def add_seller():
        obj = Seller("1","1","1","1")
        print("Seller > Create new Account >")
        print("")
        print("Enter Seller Name : ", end = '')
        obj.name = input()
        print("Enter Seller Phone Number : ", end = '')
        obj.phone_num = input()
        print("Enter Seller Buisness : ", end = '')
        obj.buisness = input()
        print("Enter Seller Password : ", end = '')
        obj.password = input()
        print("Seller id has been created")
        return obj
    @staticmethod
    def show_all_sellers():
        print("Name\tNumber\tBuisness\tPassword")
        for x in SellerDL.get_list():
            print(x.name+"\t"+x.phone_num+"\t"+x.buisness+"\t\t"+x.password)
    @staticmethod
    def no_seller():
        print("There is no Seller of such Name .")
    @staticmethod
    def seller_deleted():
        print("Seller has been deleted.")
    @staticmethod
    def take_input():
        name=input("Enter your name :")
        ipass=input("Enter your password :")
        return name,ipass
    @staticmethod
    def seller_menu():
        print(">>>   Seller Menu  >>>")
        print("")
        print("1)  Add Product")
        print("2)  View Products")
        print("3)  Sort By Price") 
        print("4)  Delete Product")
        print("5)  Update price of a Product")
        print("6)  Update Password")
        print("7)  Exit")
        print("") 
        print("Enter any option")
        return input()[0]
    @staticmethod
    def take_input_product():
        name=input("Enter the name of Product : ")
        price=float(input("Enter the price of product : "))
        return Product(name,price)
    @staticmethod
    def change_password(password):
        print("Change Password >")
        opass=input("Enter Your Old Password :")
        if(opass==password):
            newpass=input("Enter your new Password :")
            repass=input("Renter your new Password :")
            if(newpass==repass):
                if(newpass==password):
                    print("New Password cannot be the old password.")
                else:
                    print("Password Changed.")
                    return newpass
            else:
                print("New Password does not match.")
        else:
            print("You have entered the wrong password.")
        return False
    @staticmethod
    def show_all_products():
        for i in range(len(SellerDL.seller)):
            print("Seller Name : ",SellerDL.seller[i].name," >")
            print("Name\tPrice")
            for m in range(len(SellerDL.seller[i].products)):
                print(SellerDL.seller[i].products[m].name,'\t',SellerDL.seller[i].products[m].price)



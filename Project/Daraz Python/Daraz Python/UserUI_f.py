from UserBL_f import UserBL
class UserUI:
    @staticmethod
    def enter_option():
        print("1) Create new account")
        print("2) Login")
        return input()[0]
    @staticmethod
    def get_info():
        name=input("Enter your name : ")
        password=input("Enter your password : ")
        return UserBL(name,password)
    @staticmethod
    def customer_menu():
        print("///////////////////  Customer Menu  ////////////////////")
        print("")
        print("1)  View Products")
        print("2)  View Cart")
        print("3)  Payment")
        print("4)  Update Password")
        print("5)  Exit")
        print("")
        print("Enter your option")
        op = input()[0]
        return op
    def buy_product():
        return input("Enter the name of product :")
    def no_product():
        print("There is no such product .")
    def view_cart(products):
        print("Products\tPrice")
        for i in range(len(products)):
            print(products[i].name,"\t",products[i].price)
    def total_bill(total):
        print("Your total is ",total," Dollars")
        if input("Press 1 to pay . . .")[0] =='1':
            return True
        else:
            return False
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
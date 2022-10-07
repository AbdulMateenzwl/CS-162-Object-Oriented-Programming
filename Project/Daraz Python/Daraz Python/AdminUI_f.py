from AdminDL_f import AdminDL
from Admin_f import Admin
class AdminUI:
    @staticmethod
    def take_admin_info():
        a = input("Enter Username :")
        b = input("Enter Password :")
        obj = Admin(a, b)
        return obj

    @staticmethod
    def admin_menu():
        print(">>>   Admin Menu  >>>")
        print("Welcome Admin")
        print("")
        print("1)  Add Seller")
        print("2)  View Record")
        print("3)  View history")
        print("4)  Delete Seller")
        print("5)  Update Password")
        print("6)  Exit")
        print("")
        print("Enter your option")
        op = None
        op = input()[0]
        return op
    @staticmethod
    def delete_seller():
        print("Delete Seller >")
        name=input("Enter the name of seller you want to delete :")
        return name
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
                    AdminDL.admin.password=newpass
                    print("Password Changed.")
            else:
                print("New Password does not match.")
        else:
            print("You have entered the wrong password.")
    def show_history(list):
        print("History >")
        for i in range(len(list)):
            print(list[i])

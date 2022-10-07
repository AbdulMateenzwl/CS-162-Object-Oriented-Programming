from pickle import NONE
from UserBL_f import UserBL
from UserUI_f import UserUI

from UserDL_f import UserDL
from UserUI_f import UserUI
from asyncio.windows_events import NULL
import os
from Admin_f import Admin
from AdminDL_f import AdminDL
from AdminUI_f import AdminUI
from SellerDL_f import SellerDL
from SellerBL_f import Seller
from ProductUI_f import ProductUI
from MainUI_f import  mainUI
from SellerUI_f import SellerUI
def main():
    option='0'
    admin= Admin("1","2")
    m=Seller("1","1","1","1")
    UserDL.add_list(UserBL('1','1'))
    SellerDL.add_list(m)
    AdminDL.set_admin(admin)
    while option !='4':
        # os.system('cls')
        mainUI.header()
        option=mainUI.main_menu()
        if (option=='1'):
            # os.system('cls')
            mainUI.header()
            admin=AdminUI.take_admin_info()
            admin=AdminDL.chk_admin(admin)
            if(admin!=NULL):
                admin_option='9'
                while admin_option!=6:
                    # os.system('cls')
                    mainUI.header()
                    admin_option= AdminUI.admin_menu()
                    # os.system('cls')
                    mainUI.header()
                    if admin_option=='1':
                        s=SellerUI.add_seller()
                        SellerDL.add_list(s)
                        AdminDL.admin.add_history(s.name)
                    elif admin_option=='2':
                        SellerUI.show_all_sellers()
                    elif admin_option=='3':
                        AdminUI.show_history(AdminDL.admin.get_history())
                    elif admin_option=='4':
                        if(SellerDL.delete_seller(SellerDL.get_seller(AdminUI.delete_seller()))):
                            SellerUI.seller_deleted()
                        else:
                            SellerUI.no_seller()
                    elif admin_option=='5':
                        AdminUI.change_password(AdminDL.admin.password)
                    elif admin_option=='6':
                        break
                    else:
                        print("PLease enter correct input.")
                    
            else:
                print("Please enter Correct information.")
        elif option=='2':
            name,pass1=SellerUI.take_input()
            objSeller=SellerDL.get_seller_data(name,pass1)
            if(objSeller!=NULL):
                while True:
                    # os.system('cls')
                    seller_option=SellerUI.seller_menu()
                    if seller_option=='1':
                        objSeller.add_product(SellerUI.take_input_product())
                    elif seller_option=='2':
                        ProductUI.show_all_products(objSeller.products)
                    elif seller_option=='3':
                        objSeller.sort_products()
                        ProductUI.show_all_products(objSeller.products)
                    elif seller_option=='4':
                        if objSeller.delete_product(objSeller.get_product(ProductUI.product_name())):
                            ProductUI.product_deleted()
                        else:
                            ProductUI.no_product()
                    elif seller_option=='5':
                        m=objSeller.get_product(ProductUI.product_name())
                        if(m!=NULL):
                            m.price=ProductUI.product_price()
                        else:
                            ProductUI.no_product()
                    elif seller_option=='6':
                        s=SellerUI.change_password(objSeller.password)
                        if(s!=False):
                            objSeller.password=s
                    elif seller_option=='7':
                        break
                    else:
                        print("PLease enter correct input.")
            else:
                print("PLease Enter correct Cradentials.")
        elif option=='3':
            # os.system('cls')
            enter_o=UserUI.enter_option()
            if(enter_o=='1'):
                UserDL.add_list(UserUI.get_info())
            else:
                user=UserDL.check_user(UserUI.get_info())
                if(user!=None):
                    customer_option='9'
                    while customer_option != '5':
                        mainUI.header()
                        customer_option= UserUI.customer_menu()
                        mainUI.header()
                        if(customer_option=='1'):
                            SellerUI.show_all_products()
                            product=SellerDL.get_product(UserUI.buy_product())
                            if(product!=None):
                                user.add_list(product)
                            else:
                                UserUI.no_product()
                        elif customer_option=='2':
                            UserUI.view_cart(user.products)
                        elif customer_option=='3':
                            UserUI.view_cart(user.products)
                            if UserUI.total_bill(user.get_total()):
                                user.clear_products()
                        elif customer_option=='4':
                            pass1=UserUI.change_password(user.password)
                            if pass1!=False:
                                user.password=pass1
                        elif customer_option=='5':
                            break
                        else:
                            print("PLease enter correct input.")
if __name__ == "__main__":
    main()


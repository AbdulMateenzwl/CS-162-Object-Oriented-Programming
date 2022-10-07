class ProductUI:
    @staticmethod
    def show_all_products(list):
        print("Products >")
        print("Name\tPrice")
        for i in range(len(list)):
            print(list[i].name,"\t",list[i].price)
    @staticmethod
    def product_name():
        return input("Enter the name of Product : ")
    @staticmethod
    def product_price():
        return float(input("Enter the price of Product : "))
    @staticmethod
    def product_deleted():
        print("Product has been deleted.")
    @staticmethod
    def no_product():
        print("There is no such product.")
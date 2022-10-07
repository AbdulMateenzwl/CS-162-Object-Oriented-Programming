import os
class mainUI:
    @staticmethod
    def clear():
        #os.system('cls')
        for i in range(0,200):
            print("\n")

    @staticmethod
    def main_menu():
        print(">>>      Main Menu    >>>")
        print("Login :-")
        print("1) Admin")
        print("2) Seller")
        print("3) Customer")
        print("4) Exit")
        print("\n")
        op=str(input())
        return op[0]

    @staticmethod
    def header():
        #mainUI.clear()
        print("_____________________   DARAZ   _____________________\n")
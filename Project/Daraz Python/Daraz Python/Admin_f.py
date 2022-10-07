class Admin:
    username =""
    password=""
    history = []
    def __init__(self, username, password):
        self.password=password
        self.username=username
    def get_history(self):
        return self.history
    def add_history(self, input):
        self.history.append("You just added "+input+" to the list.")
    def get_username(self):
        return self.username
    def set_username(self, value):
        self.username = value
    def get_password(self):
        return self.password
    def set_password(self, value):
        self.password = value
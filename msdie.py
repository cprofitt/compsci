from random import randrange

class MSDie:
    def __init__(self, sides):
        self.sides = sides
        self.value = 1

    def roll(self):
        self.value = randrange(1, self.sides+1)

    def getValue(self):
        return self.value

    def setValue(self, value):
        self.value = value

def main():
    die1 = MSDie(6)
    die1.roll()
    print(die1.getValue())

    die2 = MSDie(6)
    die2.roll()
    print(die2.getValue())

    total = die1.getValue() + die2.getValue()

    print("your total is: " + str(total))

main ()

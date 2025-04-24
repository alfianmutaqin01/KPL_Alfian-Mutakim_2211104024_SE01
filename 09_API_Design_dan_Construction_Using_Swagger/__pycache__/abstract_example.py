from abc import ABC, abstractmethod

class vehicle(ABC):
    @abstractmethod
    def start(self):
        pass

class car(vehicle):
    def start(self):
        print("Car started")

class Motorcycle(vehicle):
    def start(self):
        print("Motorcycle started")
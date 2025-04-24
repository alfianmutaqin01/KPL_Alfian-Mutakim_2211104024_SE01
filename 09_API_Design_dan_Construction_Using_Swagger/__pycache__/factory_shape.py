class ShapeFactory:
    @staticmethod
    def get_shape(shape_type):
        if shape_type == "circle":
            return "ini adalah lingkaran"
        elif shape_type == "square":
            return "ini adalah persegi"
        elif shape_type == "rectangle":
            return "ini adalah persegi panjang"
        else:
            raise ValueError("Unknown shape type")
print(ShapeFactory.get_shape("circle"))  # Output: "ini adalah lingkaran"
print(ShapeFactory.get_shape("square"))  # Output: "ini adalah persegi" 
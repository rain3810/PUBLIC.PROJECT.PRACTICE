class Unit:
    def __init__(self):
        print("Unit 생성자")

class Flyable:
    def __init__(self):
        print("Flyable 생성자")

class FlyableUnit(Flyable, Unit ):
    def __init__(self):
        # super().__init__()  #super를 사용하면 첫번쨰 부모의 함수만 호출
        #부모의 생성자 모두 호출이 필요할때는 하기와 같이 명시해주어야함
        Unit.__init__(self) 
        Flyable.__init__(self)


#드랍쉽
#두개 이상 부모가 있을땐, Super를 쓰면 처음의 부모의 생성자만 호출
dropship = FlyableUnit() 

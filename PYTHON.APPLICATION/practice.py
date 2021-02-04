# print(max(6,5,4,43))

# from math import *
# print(float(5.77))
# print(ceil(4.15))
# print(sqrt(25))

# from random import *
# print(random())
# print(random() *10)
# print(int(random() * 10 ))
# print(int(random() * 10 ))
# print(int(random() * 10 ))
# print(int(random() * 10 + 1))
# print(int(random() * 10 + 1))
# print(int(random() * 10 + 1))
# print(int(random() * 10 + 1))
# print(int(random() * 10 + 1))

# print(int(random() * 45 ) + 1 )
# print(int(random() * 45 ) + 1 )
# print(int(random() * 45 ) + 1 )
# print(int(random() * 45 ) + 1 )
# print(int(random() * 45 ) + 1 )
# print(int(random() * 45 ) + 1 )

# print(randrange(1,46))
# print(randrange(1,46))
# print(randrange(1,46))
# print(randrange(1,46))

# print(randint(1,45))
# print(randint(1,45))
# print(randint(1,45))
# print(randint(1,45))

# from random import *
# day  = randint(4, 28)

# print("오프라인 스터디 모임 날짜는 매월 ",str( day),'일로 선정되었습니다.')

# sentence = '나는 소년입니다.'
# print(sentence)
# sentence2 ="파이썬은 쉬워요"
# print(sentence2)

# sentence3 = """
# 나는 소년이고,
# 파이썬은 쉬워요
# """
# print(sentence3)


# jumin = "990120-1234567"

# print("성별 :" , jumin[7])
# print("연 :", jumin[0:2])
# print("월 :" , jumin[2:4])
# print("일 :", jumin[4:6])

# print("생년월일 :", jumin[:6])
# print("생년월일 :", jumin[0:6])

# print("뒤 7자리", jumin[7:])
# print("뒤 7자리", jumin[7:14])
# print("뒤 7자리", jumin[-7:])

# pyhton = "Python is Amazing"
# print(pyhton.lower())
# print(pyhton.upper())
# print(pyhton[0].isupper())
# print(len(pyhton))
# print(pyhton.replace("Python", "Jave"))

# index = pyhton.index("n")
# print(index)

# index=pyhton.index("n", index +1)
# print(index)
# print(pyhton.find("n"))

# # print(pyhton.index("Java"))
# print(pyhton.find("Java"))
# print(pyhton.count("n"))

# print("A" + "B")
# print("A" ,"B")

# print("나는 %d살입니다." %20)
# print("나는 %s을 좋아해요." %'파이썬')
# print("Apple은 %c로 시작해요." %"A")

# print("나는 %s살입니다." %20)
# print("나는 %s색과 %s색을 좋아해요" %('빨강','파랑'))

# print("나는 {}살입니다.".format(20))
# print("나는 {}색과 {}색을 좋아해요".format('빨강','파랑'))
# print("나는 {1}색과 {0}색을 좋아해요".format('빨강','파랑'))

# print("나는 {age}살이며 {color}색을 좋아해요".format(age=20, color="빨강"))
# print("나는 {age}살이며 {color}색을 좋아해요".format(color="빨강", age=20 ))

# age =20
# color='빨강'
# print(f"나는 {age}살이며 {color}색을 좋아해요")

# print("백문이 불여일견\r\n백견이 불여일타")
# print('저는 "나도코딩" 입니다')
# print("저는 '나도코딩' 입니다")
# print("저는 \"나도코딩\" 입니다")
# print('저는 \'나도코딩\' 입니다')

# print("D:\\Private.Project\\PRACTICE\PYTHON.APPLICATION")

# print('Red apple\rpine')

# print('Redd\bapple')

# print('Red\tApple')
# print('Red \t Apple')

# siteaddress= "http://naver.com"
# siteaddress= "http://daum.net"
# siteaddress= "http://google.com"
# siteaddress= "http://youtube.com"

# password = siteaddress.replace("http://", "")
# password= password[:password.index('.')]
# password = "{}{}{}!".format(password[:3], len(password), password.count('e'))
# print("생성된 비밀번호 : ", password)


##리스트[]
#지하철 칸별로 10,20,30,명
# subway1= 10
# subway2 =20
# subway3 = 30
# subway= [10,20,30]

# print( subway)

# subway = ["유재석", "조세호", "박명수"]
# print(subway)

# #조세호가 몇번째칸?
# print(subway.index("조세호"))

# # 하하가 다음 정류장에서 승차
# subway.append("하하")
# print(subway)

# #사이에 집어넣기
# subway.insert(1, "정형돈")
# print(subway)

# print(subway.pop())
# print(subway)

# #같은 이름의 사람 몇명
# subway.append("유재석")
# print(subway)
# print( subway.count("유재석"))

#정렬
# num_list =[5,2,4,3,1]
# num_list.sort()
# print( num_list)

# #정렬뒤집기
# num_list.reverse()
# print(num_list)

# #모두 삭제
# num_list.clear()
# print(num_list)

# #다양한 자료형의 리스트
# mix_list = ['조세호', 20, True]
# num_list =[5,2,4,3,1]

# #리스트 확장
# num_list.extend(mix_list)
# print(mix_list)

#사전###############
#키의 중복이 허용되지 않음
# cabinet = {3:"유재석", 100:'김태호'}
# print(cabinet[3])
# print(cabinet[100])

# print(cabinet.get(3))
# print(cabinet.get(101)) #nune
# print(cabinet.get(101, '사용가능')) #사용가능

# print(3 in cabinet)
# print(5 in cabinet)

# cabinet= {'a-3':"유재석", 'b-100':'김태호'} 
# print(cabinet['a-3'])

# #새손님
# cabinet['c-20'] = '조세호'
# print(cabinet)

# cabinet['a-3'] = '김종국'
# print(cabinet)

# #간손님
# del cabinet['a-3']
# print(cabinet)

# #key search
# print(cabinet.keys())
# print(cabinet.values())

# print(cabinet.items())

# #목욕탕 폐점
# cabinet.clear()
# print(cabinet)
####################################

#튜플###############
#내용변경 및 추가를 할 순 없지만 속도가 빠름
# menu = ('돈까스', "치즈까스")
# print(menu[0])
# print(menu[1])

# # name="김종국"
# # age = 20
# # hobby = "코딩"

# # print(name,age,hobby)

# (name, age, hobby) = ("김종국", 20, "코팅")
# print(name,age,hobby)


####################################

#집합(세트)###############
#중복이 관리안되고 순서가 없음
# my_set = {1,2,3,3,3}
# print(my_set)

# java={'유재석', '김태호', '양세형'}
# python = set(['유재석', '박명수'])

# #교집합 (jave와ㅣ ㅔpython을 모두 할 수 있는 사람)
# print(java & python)
# print(java.intersection(python))

# #합집합  (java도 할 수 있거나 Python도 할 수 있는 사람 )
# print(java | python)
# print(java.union(python))

# #차집합
# print(java - python)
# print(java.difference(python))

# #python을 할 줄 아는 사람ㅇ ㅣ늘어남
# python.add("김태호")
# print(python)

# #java를 까머금
# java.remove("김태호")
# print(java)
####################################

#자료구조의 변경###############
# menu={"커피", "우유", "주스"}
# print(menu, type(menu))

# menu = list(menu)
# print(menu, type(menu))

# menu =tuple(menu)
# print(menu, type(menu))

# menu =set(menu)
# print(menu, type(menu))

####################################

#퀴즈###############
# from random import *
# lst=[1,2,3,4,5]
# print(lst)

# shuffle(lst)
# print(lst)
# print(sample(lst,1))

# users = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20]

# from random import *
# users= list(range(1,21))
# shuffle(users)
# print(users)
# chicken = sample(users, 1)
# users = set(users) - set(chicken)
# coffee = sample(users, 3)

# print('-- 당첨자 발표 --')
# print('치킨 당첨자 :{0}'.format( chicken[0]))
# print('커피 당첨자 :{0}'.format(coffee ))


# users = list(range(1,21))
# shuffle(users)
# print(users)

# winner = sample(users, 4)
# print('-- 당첨자 발표2 --')
# print('치킨 당첨자 :{0}'.format(winner[0]))
# print('커피 당첨자 :{0}'.format(winner(1:3)))

####################################

#IF###############


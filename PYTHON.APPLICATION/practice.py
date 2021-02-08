# print(5)
# print(-10)
# print(3.14)
# print(1000)
# print(5+3)
# print(2*8)
# print(3*(3+1))

# print('풍선')
# print("나비")
# print("ㅋㅋㅋㅋ")
# print("ㅋ"*9)

# print(5>10)
# print(5<10)
# print(True)
# print(False)
# print(not True)
# print(not False)
# print(not(5>10) )

# '''이렇게 하면 주석이 여러개'''
# animal = "고양이"
# age =4
# name ="해피"
# hobby = "낮잠"
# is_adult = age >3
# print("우리집 " + animal + "의 이름은 " + name+"예요")

# hobby = "공놀이"

# # print(name+"는 " + str(age) + "살이며, "+hobby +"을 아주 좋아해요.")
# print(name, " 는 " , age, "살이며, ",hobby ,"을 아주 좋아해요.")
# print( name + "는 어른일까요? " + str(is_adult))

# station = '사당'
# print(station + '행 열차가 들어오고 있습니다.')
# station = '신도림'
# print(station + '행 열차가 들어오고 있습니다.')
# station = '인청공항'
# print(station + '행 열차가 들어오고 있습니다.')

# print(1+2)
# print(2**3)
# print(5//3)
# print(5/3)
# print(5%3)
# print(10 >3)
# print (4 >=7)
# print( 10 <3)
# print(4 <=4)
# print(3==3)
# print(3==2)
# print(3+4 == 7)

# print(3!=3)
# print(1 != 3)
# print(not (1!=1))

# print((3 >0) and (3<5))
# print((3>0 &(3<5)))

# print((3 > 0) or (3 > 5))
# print((3 > 0) | (3 > 5))

# print(5>4>3)
# print(5>4>7)

# print(2+3 *4)
# print(2+3)

# number= 2 +3 *4
# print(number)
# number +=2
# print(number)

# number *=2
# print(number)
# number /=2
# print(number)
# number %=5
# print(number)

# print(abs(-5)) 
# print (pow(4,2))
# print(max(5,2,10))
# print(min(2,3,5))
# print(round(3.14))


# from math import *
# print(floor(4.99))
# print(ceil(3.14))
# print(sqrt(16))

# 3-4 랜덤함수
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
# weather = input('오늘 날씨는 어때요?\r\n')
# # weather = '맑아요'
# if weather =="비" or weather=="눈":
#     print('우산을 챙기세요.')
# elif weather == '미세먼지':
#     print('마스트!')
# else:
#     print("준비물 필요없어요.")

# temp = int(input('기온은 어때요?\r\n'))
# if 30 <= temp:
#     print('너무 더워요. 나가지 마세요')
# elif 10 <= temp and 30 >temp:
#     print('괜찮은 날씨예요.')
# elif 0 <=temp <10: #elif temp >=0  and temp <10:
#     print ('외투를 챙기세요.')
# else:
#     print ('너무 추워요. 나가지 마세요')
####################################

#FOR###############
# print('대기번호 : 1')
# print('대기번호 : 2')
# print('대기번호 : 3')
# print('대기번호 : 4')

# for waiting_no in range(1,6):
#     print('대기번호 : {0}'.format(waiting_no))

# starbuck = ['아이언맨', '토르', '아이엠 그루트']
# for customer in starbuck:
#     print('{0}, 커피가 준비되었습니다.'.format(customer))
####################################

#WHILE###############
# customer ='토르'
# index = 5

# while index >=1:
#     print('{0}, 커피가 준비되었습니다. {1}번 남았어요.'.format(customer,index))
#     index-=1

#     if index ==0:
#         print('커피는 폐기처분 되었습니다.')


# customer ='아이언맨'
# index = 1

# while True:
#     print('{0}, 커피가 준비되었습니다. {1}번 남았어요.'.format(customer,index))
#     index+=1


# customer = '토르'
# person = 'unknown'

# while person != customer:
#     print('{0}, 커피가 준비되었습니다.'.format(customer))
#     person = input('이름이 어떻게 되세요?')

####################################

#continue와 break###############
# absent =[2,5] 
# no_book = [7]

# for student in range(1, 11):
#     if student in absent:
#         continue
#     elif  student in no_book:
#         print('오늘 수업 여기까지. {0}는 교무실로 따라와'.format(student))
#         break
#     print('{0}, 책을 읽어봐'.format(student))
####################################

#한줄 for###############
#출석번호가 101,102,103....
# student =[1,2,3,4,5]
# print(student)
# student=[i +100 for i in student]
# print(student)

# student = ['iron name', 'thor', 'i am groot']
# student=[len(st) for st in student]
# print(student)
# student = ['iron name', 'thor', 'i am groot']
# student = [std.upper() for std in student]
# print(student)

####################################
#퀴즈###############

# from random import *

# people = list(range(1,51))
# myUser = 0

# for user in range(1,51):#people:
#     time =randint(5, 50)
    
#     if 5 <= time <= 15:
#         myUser +=1
#         print('[O] {0}번쨰 손님 (소요시간 : {1}분)'.format(user, time))
#     else:
#         print('[ ] {0}번쨰 손님 (소요시간 : {1}분)'.format(user, time))

# print('총 탑승 승객 : {0} 분'.format(myUser))
####################################
#함수###############

# def open_account():
#     print('새로운 계좌가 생성되었습니다.')

# open_account()
####################################
#전달값과 반환값###############

# def open_account():
#     print('새로운 계좌가 생성되었습니다.')

# def deposit(balance, money):
#     print('입금이 완료되었습니다. 잔액은 {0} 원입니다.'.format(balance + money))
#     return balance + money

# def withdraw (balance, money):
#     if balance > money:
#         print('출금이 완료되었습니다. 잔액은 {0} 원입니다.'.format(balance-money))
#         return balance-money
#     else:
#         print('출금이 완료되지 않았습니다. 잔액은 {0} 원입니다.'.format(balance))
#         return balance

# def withdraw_night(balance, money):
#     commission= 100
#     return commission, balance-money -commission

# balance = 0
# balance = deposit(balance, 1000)
# # balance = withdraw(balance, 500)

# commission, balance = withdraw_night(balance, 500)

# print('수수료는 {0} 원이며, 잔액은 {1} 원입니다.'.format(commission,balance))

####################################
#기본값###############
# def profile(name, age, main_lang):
#     print('이름은 : {0}\t나이 : {1}\t주 사용언어 : {2}'\
#         .format(name,age,main_lang ))

# profile('유재석', 20, '파이썬')
# profile('김태호', 25, '자바')

#같은 동기라면?
# def profile(name, age=17, main_lang='파이썬'):
#     print('이름은 : {0}\t나이 : {1}\t주 사용언어 : {2}'\
#         .format(name,age,main_lang ))

# profile('유재석')
# profile('김태호')

# ####################################
# #키워드값###############
 
# def profile(name,age, main_lang):
#      print(name,age,main_lang)

# profile(name='유재석', age=20, main_lang='파이썬')
# profile(main_lang='자바', name='김태호', age=25)
####################################
#가변인자###############
# def profile(name, age, lang1,lang2,lang3,lang4,lang5):
#     print('name : {0}\tage : {1}\t'.format(name,age), end=" ")
#     print(lang1,lang2,lang3,lang4,lang5)

# def profile2(name, age, *language):
#     print('name : {0}\tage : {1}\t'.format(name,age), end=" ")
#     for lang in language:
#         print(lang, end=' ')
#     print()


# profile('유재석', 20, 'python', 'java', 'c', 'c++', 'C#')
# profile('김태호', 25, 'kotlin', 'Swift', '', '', '')
# profile2('유재석', 20, 'python', 'java', 'c', 'c++', 'C#', 'javascript')
# profile2('김태호', 25, 'kotlin', 'Swift')
####################################
#지역변수와 전역변수###############
# gun = 10
# def checkpoint(soldiers):
#     global gun #전역 공간에 있는 gun 사용
#     gun = gun - soldiers
#     print("[함수 내] 남은 총 : {0}".format(gun))

# def checkpoint_ret(gun, soldiers):
#     gun = gun-soldiers
#     print("[함수 내] 남은 총 : {0}".format(gun))
#     return gun


# print('전체  총 : {0}'.format(gun))
# # checkpoint(2)
# gun= checkpoint_ret(gun,2)
# print('남은  총 : {0}'.format(gun)) 
####################################
#퀴즈###############
# from math import *

# def std_weight(height, gender):
#     if gender == '여자':
#         return pow((height /100),2)* 21
#     else :
#         return pow((height /100),2) * 22

# height = 175
# gender = '남자'
# weigh = std_weight(height, gender)

# print('키 {0}cm {1}의 표준 체중은 {2}kg 입니다.'.format(height, gender, round(weigh,2)))
####################################
#표준입출력###############
# print('python', 'java',  sep=',', end="?")
# print('무엇이 더 재미있을까요?')

# import sys
# print('python', 'java', file=sys.stdout)    #표준 출력으로 처리
# print('python', 'java', file=sys.stderr)    #표준 에러로 처리

# scores ={'math':0, 'Eng':50,'coding':100 }
# for subject, score in scores.items():
#     # print(subject, score)
#     print(subject.ljust(8), str(score).rjust(4), sep=':')

# #은행 대기 순번표 001,002,003
# for number in range(1, 21):
#     print('대기번호 :' + str(number).zfill(3))

# answer =input('아무 값이나 입력하세요 : ')
# answer = 10
# print(type(answer))
# print('입력하신 값은 ' + answer + '입니다.')
####################################
#다양한 출력 포맷###############
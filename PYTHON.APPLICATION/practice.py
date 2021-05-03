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
#01 빈 자리는 빈 공간으로 두고, 오른쪽 정렬을 하되, 총 10자리  공간을 확보
# print("{0: >10}".format(500))
# print("{0: >10}".format(+500))
# print("{0: >10}".format(-500))
# #02 양수일땐 +로 음수일땐 -로 표시 (주식 예)
# print("{0: >+10}".format(500))
# print("{0: >+10}".format(-500))
# #03 왼쪽 정렬을 하고, 빈칸을 _로 채움
# print("{0:_<+10}".format(500))
# print("{0:_<+10}".format(-500))
# #04 3자리마다 콤마를 찍어주기
# print("{0:,}".format(10000000000000000))    
# #05 3자리마다 콤마를 찍어주기, +-부호도 붙이기
# print('{0:+,}'.format(10000000000000000))
# #06 3자리마가 콤마, +-부호, ^로자릿수  확보
# #출력포맷 순서
# #빈값채우는CHAR,정렬방향,부호,자릿수,콤마
# print('{0:^<+30,}'.format(10000000000000000))
# #소수점 출력
# print('{0:f}'.format(5/3))
# #소수점 특정 자릿수 까지만 표시 (이후는 반올림)
# print('{0:.2f}'.format(5/3))
####################################

#파일 입출력###############
# score_file = open('score.txt', 'w', encoding="utf8")
# print("수학 : 0", file=score_file)
# print("영어 : 50", file=score_file)
# score_file.close()

# score_file = open("score.txt", "a", encoding="utf8")
# score_file.write("과학 : 80")
# score_file.write("\n코딩 : 100")
# score_file.close()

# score_file = open("score.txt",'r', encoding="utf8")
# print(score_file.read())
# score_file.close()

# score_file = open("score.txt",'r', encoding="utf8")
# print(score_file.readline(), end="") #줄별로 읽기, 한줄읽고 커서는 다음줄로 이동
# print(score_file.readline(), end="") #줄별로 읽기, 한줄읽고 커서는 다음줄로 이동
# print(score_file.readline()) #줄별로 읽기, 한줄읽고 커서는 다음줄로 이동
# print(score_file.readline()) #줄별로 읽기, 한줄읽고 커서는 다음줄로 이동
# score_file.close()

# score_file = open("score.txt",'r', encoding="utf8")
# while True:
#     line= score_file.readline()
#     if not line:
#         break
#     print(line, end="")

# score_file.close()

# score_file = open("score.txt",'r', encoding="utf8")
# lines = score_file.readlines()

# for line in lines:
#     print(line, end="")

# score_file.close()

####################################

#피클############### 
## 피클이란, 사용하고 있는 데이터를 파일로 저장하는것, 이후 다른 사람과 주고 받아서 데이터로 활용 가능하다.
# import pickle
# profile_file = open("profile.pickle", "wb") #항상 binary 타입으로 피클을 이용해야 한다.
# profile = {"이름" : "박명수", "나이":30, "취미" : ["축구", "골프", "코딩"]}
# print(profile)

# pickle.dump(profile, profile_file) #profile의 정보를 file에 저장
# profile_file.close()

# profile_file = open("profile.pickle", "rb") # 읽기(Binary 명시)
# profile = pickle.load(profile_file) #file에 있는 정보를 profile에 불러오기
# print(profile)

# profile_file.close()

####################################

#With(수월하게 파일 처리 가능)############### 
## 피클은 파일 열고 닫는 기능이나, with는 더 확장된 기능 사용가능
# import pickle

# with open("profile.pickle", "rb") as profile_file:  #With를 쓸때는 Close 를 따로 써서 닫아줄 필요가 없다. (With 문을 탈출할때 자동으로 호출됨)
#     print(pickle.load(profile_file))

# with open ("study.txt" ,"w", encoding="utf8") as study_file:
#     study_file.write("파이썬을 열심히 공부하고 있어요.")

# with open("study.txt", "r", encoding="utf8") as study_file:
#     print(study_file.read())

####################################
#퀴즈###############

# import pickle

# for week in range(1, 21):
#     with open("{0}주차.txt".format(week), "w", encoding="utf8") as report: # 대체가능:  open(str(week) + "주차.txt", "w", encoding="utf8")
#         report.write("- {0}주차 주간 보고 -".format(week))
#         report.write("\n부서 :")
#         report.write("\n이름 :")
#         report.write("\n업무 요약 :")


####################################
#클래스###############

# # 마린 : 공격 유닛, 군인. 총을 쏠 수 있있음
# name = "마린"   #유닛의 이름
# hp = 40         #유닛의 체력
# damage = 5      #유닛의 공격력

# print("{} 유닛이 생성되었습니다.".format(name))
# print("체력 {0}, 공격력 {1}\n".format(hp, damage))

# #탱크 : 공격 유닛, 탱크. 포를 쏠 수 있는데, 일반모드/시즈모드.
# tank_name = "탱크"   #유닛의 이름
# tank_hp = 150         #유닛의 체력
# tank_damage = 35      #유닛의 공격력

# print("{} 유닛이 생성되었습니다.".format(tank_name))
# print("체력 {0}, 공격력 {1}\n".format(tank_hp, tank_damage))

# def attack(name, location, damage):
#     print("{0} : {1} 방향으로 적군을 공격합니다. [공격력 {2}]".format(name, location,damage))

# attack(name, "1시", damage)
# attack(tank_name, "1시", tank_damage)

# class Unit:
#     def __init__(self, name, hp, damage):
#         self.name = name
#         self.hp = hp
#         self.damage = damage
#         print("{0} 유닛이 생성되었습니다.".format(self.name))
#         print("체력 {0}, 공격력 {1}".format(self.hp, self.damage))

# marine1= Unit("마린", 40, 5)
# marine2= Unit("마린", 40, 5)
# tank = Unit("탱크", 150, 35)

# ####################################
# #__init__###############
# # 파이썬에서 쓰이는 생성자임.
# marine3= Unit("마린", 40) #오류!!

####################################
#멤버 변수###############
#클래스 내 정의된 변수를 멤버 변수라고 한다.
#레이스 : 공중 유닛, 비행기. 클로킹 기능이 있음(상대방에게 보이지 않음)

# wraith1 = Unit('레이스', 80,5)
# print("유닛 이름 : {0}, 공격력 : {1}".format(wraith1.name, wraith1.damage))

# #마인드 컨트롤 : 상태방 유닛을 내 것으로 만드는 것 (빼앗음)
# wraith2 = Unit("빼앗은 레이스", 80, 5)
# wraith2.clocking = True       #파이썬은 외부에서 추가로 변수를 만들어 사용할 수 있다.

# if wraith2.clocking == True :
#     print("{0}는 현재 클로킹 상태입니다.".format(wraith2.name))

####################################
#메소드###############
#클레스 내에서 메소드의 제일 첫번째 인자는 항상 self 여야 한다.

# #공격 유닛
# class AttackUnit:
#     def __init__(self, name, hp, damage):
#         self.name = name
#         self.hp = hp
#         self.damage = damage
    
#     def attack(self, location):
#         print("{0}이 {1} 방향으로 적군을 공격 합니다. [공격력 {2}]"\
#             .format(self.name, location, self.damage))

#     def damaged(self, damage):
#         print("{0} : {1} 데미지를 입었습니다.".format(self.name, damage))
#         self.hp -= damage
#         print("{0} : 현재 체력은 {1}입니다.".format(self.name, self.hp))

#         if self.hp <=0 :
#             print("{0} : 파괴되었습니다.".format(self.name))

# # 파이어뱃 : 공격 유닛, 화염방사기
# firebat1 = AttackUnit("파이어뱃", 50, 16)
# firebat1.attack("5시")

# #공격을 2번 받음
# firebat1.damaged(25)
# firebat1.damaged(25)

####################################
#상속###############

# #메딕 : 의무병

# #일반 유닛
# class Unit:
#     def __init__(self, name, hp):
#         self.name = name
#         self.hp = hp

# #공격 유닛
# class AttackUnit(Unit):
#     def __init__(self, name, hp, damage):
#         Unit.__init__(self, name, hp)       #부모 클래스의 생성자 호출
#         self.damage = damage
    
#     def attack(self, location):
#         print("{0}이 {1} 방향으로 적군을 공격 합니다. [공격력 {2}]"\
#             .format(self.name, location, self.damage))

#     def damaged(self, damage):
#         print("{0} : {1} 데미지를 입었습니다.".format(self.name, damage))
#         self.hp -= damage
#         print("{0} : 현재 체력은 {1}입니다.".format(self.name, self.hp))

#         if self.hp <=0 :
#             print("{0} : 파괴되었습니다.".format(self.name))

# # 파이어뱃 : 공격 유닛, 화염방사기
# firebat1 = AttackUnit("파이어뱃", 50, 16)
# firebat1.attack("5시")

# #공격을 2번 받음
# firebat1.damaged(25)
# firebat1.damaged(25)

####################################
#다중 상속###############
#여러곳에서 상속을 받을 수있음


#메딕 : 의무병

#일반 유닛
class Unit:
    def __init__(self, name, hp):
        self.name = name
        self.hp = hp

#공격 유닛
class AttackUnit(Unit):
    def __init__(self, name, hp, damage):
        Unit.__init__(self, name, hp)       #부모 클래스의 생성자 호출
        self.damage = damage
    
    def attack(self, location):
        print("{0}이 {1} 방향으로 적군을 공격 합니다. [공격력 {2}]"\
            .format(self.name, location, self.damage))

    def damaged(self, damage):
        print("{0} : {1} 데미지를 입었습니다.".format(self.name, damage))
        self.hp -= damage
        print("{0} : 현재 체력은 {1}입니다.".format(self.name, self.hp))

        if self.hp <=0 :
            print("{0} : 파괴되었습니다.".format(self.name))

# 드랍쉽 : 공중 유닛, 수송기. 마린/ 파이어뱃/ 탱크 등을 수송. 공격 X

#날 수 있는 기능을 가진 클래스
class Flyable:
    def __init__(self, flying_speed):
        self.flying_speed = flying_speed

    def fly(self, name, location):
        print("{0} : {1} 방향으로 날아갑니다. [속도 {2}]".format(name, location, self.flying_speed))

#공중 공격 유닛 클래스
class FlyableAttackUnit(AttackUnit, Flyable):
    def __init__(self, name, hp, damage, flying_speed):
        AttackUnit.__init__(self,name, hp, damage)
        Flyable.__init__(self, flying_speed)

#발키리 : 공중 공격 유닛, 한번에 14발 미사일 발사.
valkyrie = FlyableAttackUnit("발키리", 200, 6, 5)
valkyrie.fly(valkyrie.name, "3시")



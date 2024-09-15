import datetime

print ("Hello!. I will predict when you turn 100")
name = input(' What is your name ?')
print (name)
age = int(input ('What is your age '))
print (age)

currentDateTime = datetime.datetime.now()
print(currentDateTime)

currentDate = currentDateTime.date()
print (currentDate)

currentYear = currentDate.year
print (currentYear)


#print (datetime.date().year)
yearsTo100 = 100 - age;
year100 = currentYear + yearsTo100;
print(year100)
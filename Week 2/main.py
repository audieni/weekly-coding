def int_to_str(x):
    return '{}'.format(x)

def str_to_int(x):
    num = 0
    for ch in x:
        num = num * 10 + ord(ch) - 48
    return num

if __name__ == '__main__':
    print(f'{int_to_str(4)} is of type {type(int_to_str(4))}')
    print(f'{str_to_int("4")} is of type {type(str_to_int("4"))}')
    print(f'{int_to_str(29348)} is of type {type(int_to_str(29348))}')
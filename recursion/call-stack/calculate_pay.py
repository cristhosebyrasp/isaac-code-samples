def calculate_pay(h, r):
    """Performs a basic pay calculation."""
    pay =  h * r
    return pay


def main():
    """A simple pay calculation program."""
    hours = input('Enter hours worked ')
    rate = input('Enter hourly rate ')
    hours_int = float(hours)
    rate_int = float(rate)
    pay = calculate_pay(hours_int, rate_int)
    print('Your pay is £{:.2f}'.format(pay))


if __name__ == '__main__':
    main()

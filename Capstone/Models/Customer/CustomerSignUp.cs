using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class CustomerSignUp
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "Name:")]
        public string CustomerName { get; set; }
        [Display(Name = "Birth Date:")]
        public CustomerBirthYears CustomerBirthYear { get; set; }
        public enum CustomerBirthYears    //dropdown menu for birthdate, then calculate age
        {   
            1917
            1918
            1919
            1920
            1921
            1922
            1923
            1924
            1925
            1926
            1927
            1928
            1929
            1930
            1931
            1932
            1933
            1934
            1935
            1936
            1937
            1938
            1939
            1940
            1941
            1942
            1943
            1944
            1945
            1946
            1947
            1948
            1949
            1950
            1951
            1952
            1953
            1954
            1955
            1956
            1957
            1958
            1959
            1960 
            1961
            1962
            1963
            1964
            1965
            1966
            1967
            1968
            1969
            1970
            1971
            1972
            1973
            1974
            1975
            1976
            1977
            1978
            1979
            1980
            1981
            1982
            1983
            1984
            1985
            1986
            1987
            1988
            1989
            1990
            1991
            1992
            1993
            1994
            1995
            1996
            1997
            1998
            1999
        }
        [Display(Name = "Email Address:")]
        public string CustomerEmail { get; set; }
        [Display(Name = "Password:")]
        public string CustomerPassword { get; set; }
    }
}
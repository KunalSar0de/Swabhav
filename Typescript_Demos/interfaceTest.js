printDetails([{ firstName: 'kunal', id: 101, lastname: 'sarode' },
    { firstName: 'sagar', id: 102, lastname: 'avhad' },
    { firstName: 'chinmay', id: 103, lastname: 'sakhare' }]);
function printDetails(customers) {
    for (var c in customers) {
        console.log(c);
    }
}

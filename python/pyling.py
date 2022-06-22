import os
import argparse
import sys
import nose2


def error(*args, **kwargs):
    print(*args, file=sys.stderr, **kwargs)
    exit(1)


def init(path):
    print('Initialising module in {}'.format(path))
    create_folder(path, 'src')
    create_folder(path, 'test')


def create_module(path, module_name):
    src_path = os.path.join(path, 'src')
    test_path = os.path.join(path, 'test')

    if not os.path.exists(src_path) or not os.path.exists(test_path):
        error('Paths don\'t exist. Did you call init?')

    source_file_path = os.path.join(src_path, '{}.{}'.format(module_name, 'py'))
    source_file = open(source_file_path, 'w+')
    source_file.close()

    test_file_path = os.path.join(test_path, 'test_{}.{}'.format(module_name, 'py'))
    test_file = open(test_file_path, 'w+')
    test_file.write('import {}{}'.format(module_name, os.linesep))
    test_file.write('import unittest{}'.format(os.linesep))
    test_file.write(os.linesep)
    test_file.write('class Test{}(unittest.TestCase):{}'.format(module_name.capitalize(), os.linesep))
    test_file.write('    def setUp(self):{}        pass{}'.format(os.linesep, os.linesep*2))
    test_file.write('    def tearDown(self):{}        pass{}'.format(os.linesep, os.linesep*2))
    test_file.write('    def test_implementMe(self):{}        self.fail(\'Not Implemented\'){}'.format(
        os.linesep, os.linesep)
    )
    test_file.close()

    print('.. {}{}... {}'.format(source_file_path, os.linesep, test_file_path))


def test(path):
    argv = ['-t{}'.format(path), '-s{}'.format(path), 'test']
    nose2.discover(argv=argv)


def create_folder(path, folder_name):
    full_path = os.path.join(path, folder_name)
    if not os.path.exists(full_path):
        os.makedirs(full_path)
        f = open(os.path.join(full_path, '__init__.py'), 'w+')
        f.close()


def main():
    parser = argparse.ArgumentParser(description='Initialise python kata environment')
    parser.add_argument('--init', action='store_true', default=False)
    parser.add_argument('--createModule', nargs='*', default=[])
    parser.add_argument('--path', type=str, dest='path', default=os.getcwd())
    parser.add_argument('--test', action='store_true', default=False)

    if len(sys.argv) < 2:
        parser.print_help(sys.stderr)
        exit(2)

    args = parser.parse_args()

    if args.init:
        init(args.path)
    if len(args.createModule) > 0:
        print('Creating Module(s):')
    for module in args.createModule:
        create_module(args.path, module)
    if args.test:
        test(os.path.abspath(args.path))


if __name__ == '__main__':
    main()

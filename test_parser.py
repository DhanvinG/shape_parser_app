import os
from shape_parser import parse_shape

test_dir = "tests"

for fname in os.listdir(test_dir):
    if fname.endswith(".fs"):
        print(f"\n===== {fname} =====")
        with open(os.path.join(test_dir, fname), "r") as f:
            content = f.read()
            result = parse_shape(content)
            print("Detected shape:", result.shape)
            print("Parameters:", result.parameters)
            print("Feature vector:", result.feature_vector)
            print("=" * 50)
